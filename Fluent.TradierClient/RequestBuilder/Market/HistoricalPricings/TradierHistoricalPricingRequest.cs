using Fluent.TradierClient.Helper;
using Fluent.TradierClient.RequestBuilder.HistoricalPricings.HistoricalPricing.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings
{
    /// <summary>
    /// Tradier historical web request.
    /// </summary>
    /// <seealso cref="TradierWebRequest{List{TradierHistoricalPricing}}" />
    public class TradierHistoricalPricingRequest
        : TradierWebRequest<List<TradierHistoricalPricing>>
    {
        /// <summary>
        /// The command
        /// </summary>
        private readonly TradierHistoricalPricingCommand Command;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierHistoricalPricingRequest"/> class.
        /// </summary>
        /// <param name="cmd">The command.</param>
        /// <exception cref="ArgumentNullException">cmd</exception>
        protected TradierHistoricalPricingRequest(TradierHistoricalPricingCommand cmd)
            : base(cmd?.BaseUrl, cmd?.AccessKey)
        {
            Command = cmd ?? throw new ArgumentNullException(nameof(cmd));
        }

        /// <summary>
        /// Gets the history data asynchronously.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        /// <returns>Historical data from Tradier.</returns>
        public static async Task<List<TradierHistoricalPricing>> GetHistoryDataAsync(
            Func<TradierHistoricalPricingCommand> commandBuilder)
                => await new TradierHistoricalPricingRequest(commandBuilder()).GetAsync();

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The list of historical pricing.</returns>
        protected override List<TradierHistoricalPricing> Deserialize(JToken jToken) =>
            SafeListDeserialize<TradierHistoricalPricing>(jToken, "history.day");

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>URL for historical stock data.</returns>
        protected override string RelativeUrl()
        {
            var relativeUrl = $"markets/history?symbol={Command.Symbol}";

            var @params = new Dictionary<string, string>();
            if (Command.Interval.HasValue)
            {
                @params.Add("interval", Command.Interval.ToString().ToLower());
            }
            if (Command.StartDate.HasValue)
            {
                @params.Add("start", Command.StartDate.Value.ToString(DateTimeFormats.YearDateFormat));
                if (Command.EndDate.HasValue)
                {
                    @params.Add("end", Command.EndDate.Value.ToString(DateTimeFormats.YearDateFormat));
                }
            }
            if (@params.Any())
            {
                relativeUrl += ("&" + string.Join("&", @params.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value))));
            }
            return relativeUrl;
        }
    }
}