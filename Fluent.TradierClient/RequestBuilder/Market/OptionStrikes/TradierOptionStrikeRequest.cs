using Fluent.TradierClient.Helper;
using Fluent.TradierClient.RequestBuilder.Market.OptionExpirations;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionStrikes
{
    /// <summary>
    /// Tradier option strike request.
    /// </summary>
    /// <seealso cref="TradierWebRequest{List{decimal}}" />
    public class TradierOptionStrikeRequest
        : TradierWebRequest<List<decimal>>
    {
        /// <summary>
        /// The command
        /// </summary>
        private readonly TradierOptionStrikeCommand Command;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionStrikeRequest"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <exception cref="ArgumentNullException">command</exception>
        protected TradierOptionStrikeRequest(TradierOptionStrikeCommand command)
            : base(command?.BaseUrl, command?.AccessKey)
        {
            Command = command ?? throw new ArgumentNullException(nameof(command));
        }

        /// <summary>
        /// Gets the option strikes asynchronous.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        /// <returns>List of option strikes.</returns>
        /// <exception cref="ArgumentNullException">commandBuilder</exception>
        public static async Task<List<decimal>> GetOptionStrikesAsync(Func<TradierOptionStrikeCommand> commandBuilder)
        {
            var cmd = commandBuilder?.Invoke() ?? throw new ArgumentNullException(nameof(commandBuilder));
            if (cmd.ExpiryDateRangeLimit.HasValue && cmd.ExpiryDateRangeLimit >= 1)
            {
                return await MultipleOptionChainForAutoExpiryAsync(cmd);
            }

            return await new TradierOptionStrikeRequest(commandBuilder()).GetAsync();
        }

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The list of strikes in decimal.</returns>
        protected override List<decimal> Deserialize(JToken jToken) =>
                SafeListDeserialize<decimal>(jToken, "strikes.strike");

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>Url for option strikes.</returns>
        protected override string RelativeUrl() =>
            $"markets/options/strikes?symbol={Command.Symbol}&expiration={Command.ExpirationDate.ToString(DateTimeFormats.YearDateFormat)}";

        /// <summary>
        /// Gets the option strikes based on auto expiry dates for option chain asynchronous.
        /// </summary>
        /// <param name="cmd">The command.</param>
        /// <returns>Option strikes for date range.</returns>
        private static async Task<List<decimal>> MultipleOptionChainForAutoExpiryAsync(TradierOptionStrikeCommand cmd)
        {
            var expirationDates = await new TradierOptionExpirationRequest(
                    new TradierOptionExpirationCommand(cmd, cmd.Symbol)).GetAsync();

            var tasks = expirationDates.Take(cmd.ExpiryDateRangeLimit.Value)
                  .Select(date => new TradierOptionStrikeRequest(new TradierOptionStrikeCommand(cmd)
                  {
                      Symbol = cmd.Symbol,
                      ExpirationDate = date
                  }).GetAsync()).ToList();

            var wholeData = new List<decimal>();

            await Task.WhenAll(tasks).ContinueWith(res =>
                res.Result.ToList().ForEach(tResult => wholeData.AddRange(tResult)));

            return wholeData;
        }
    }
}