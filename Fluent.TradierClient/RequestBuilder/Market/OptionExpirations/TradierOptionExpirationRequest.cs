using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionExpirations
{
    /// <summary>
    /// Option expiration request.
    /// </summary>
    /// <seealso cref="TradierWebRequest{List{DateTime}}" />
    public class TradierOptionExpirationRequest
        : TradierWebRequest<List<DateTime>>
    {
        /// <summary>
        /// The command
        /// </summary>
        private readonly TradierOptionExpirationCommand Command;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionExpirationRequest"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        internal TradierOptionExpirationRequest(TradierOptionExpirationCommand command)
            : base(command?.BaseUrl, command?.AccessKey)
        {
            Command = new TradierOptionExpirationCommand(command, command?.Symbol);
        }

        /// <summary>
        /// Gets the option expiry asynchronous.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        /// <returns>Instance of <see cref="TradierOptionExpirationRequest"/>.</returns>
        public static async Task<List<DateTime>> GetOptionExpiryAsync(Func<TradierOptionExpirationCommand> commandBuilder)
            => await new TradierOptionExpirationRequest(commandBuilder?.Invoke()).GetAsync();

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The list of expiration dates.</returns>
        protected override List<DateTime> Deserialize(JToken jToken) =>
                SafeListDeserialize<DateTime>(jToken, "expirations.date");

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>Url for option expirations.</returns>
        protected override string RelativeUrl() =>
            $"markets/options/expirations?symbol={Command.Symbol}";
    }
}