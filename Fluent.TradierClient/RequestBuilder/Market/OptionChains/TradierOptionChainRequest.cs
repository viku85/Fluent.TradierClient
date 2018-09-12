using Fluent.TradierClient.Helper;
using Fluent.TradierClient.RequestBuilder.Market.OptionChains.Model;
using Fluent.TradierClient.RequestBuilder.Market.OptionExpirations;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionChains
{
    /// <summary>
    /// Tradier Option chain request.
    /// </summary>
    /// <seealso cref="TradierWebRequest{List{TradierOptionChain}}" />
    public class TradierOptionChainRequest
        : TradierWebRequest<List<TradierOptionChain>>
    {
        /// <summary>
        /// The command
        /// </summary>
        private TradierOptionChainCommand Command;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionChainRequest"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <exception cref="ArgumentNullException">command</exception>
        private TradierOptionChainRequest(TradierOptionChainCommand command)
            : base(command?.BaseUrl, command.AccessKey)
        {
            Command = command ?? throw new ArgumentNullException(nameof(command));
        }

        /// <summary>
        /// Gets the option chain asynchronous.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        /// <returns>Values for option chain based on command builder.</returns>
        /// <exception cref="ArgumentNullException">commandBuilder</exception>
        public static async Task<List<TradierOptionChain>> GetOptionChainAsync(Func<TradierOptionChainCommand> commandBuilder)
        {
            if (commandBuilder == null)
            {
                throw new ArgumentNullException(nameof(commandBuilder));
            }
            var cmd = commandBuilder();
            if (cmd.ExpiryDateRangeLimit.HasValue && cmd.ExpiryDateRangeLimit >= 1)
            {
                return await GetMultipleOptionChainForAutoExpiry(cmd);
            }
            return await new TradierOptionChainRequest(cmd).GetAsync();
        }

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The list of option chains.</returns>
        protected override List<TradierOptionChain> Deserialize(JToken jToken) =>
            SafeListDeserialize<TradierOptionChain>(jToken, "options.option");

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>URL for option chain.</returns>
        protected override string RelativeUrl() =>
            $"markets/options/chains?symbol={Command.Symbol}&expiration={Command.Expiry.ToString(DateTimeFormats.YearDateFormat)}";

        /// <summary>
        /// Gets the multiple option chain for automatic expiry.
        /// </summary>
        /// <param name="cmd">The command.</param>
        /// <returns>List of option chain.</returns>
        private static async Task<List<TradierOptionChain>> GetMultipleOptionChainForAutoExpiry(TradierOptionChainCommand cmd)
        {
            var expirationDates = await new TradierOptionExpirationRequest(
                    new TradierOptionExpirationCommand(cmd, cmd.Symbol)).GetAsync();

            var tasks = expirationDates.Take(cmd.ExpiryDateRangeLimit.Value)
                  .Select(date => new TradierOptionChainRequest(
                                        new TradierOptionChainCommand(cmd, cmd.Symbol, date))
                                .GetAsync()).ToList();

            var wholeData = new List<TradierOptionChain>();

            await Task.WhenAll(tasks).ContinueWith(res =>
                res.Result.ToList().ForEach(tResult => wholeData.AddRange(tResult)));

            return wholeData;
        }
    }
}