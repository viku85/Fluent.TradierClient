using Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Commands;
using Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.MarketCalenders
{
    /// <summary>
    /// Tradier Calendar request.
    /// </summary>
    /// <seealso cref="TradierWebRequest{List{TradierMarketCalender}}" />
    public class TradierMarketCalenderRequest
        : TradierWebRequest<List<TradierMarketCalender>>
    {
        /// <summary>
        /// The command
        /// </summary>
        private readonly TradierMarketCalenderCommand Command;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierMarketCalenderRequest"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <exception cref="ArgumentNullException">command</exception>
        protected TradierMarketCalenderRequest(TradierMarketCalenderCommand command)
            : base(command?.BaseUrl, command?.AccessKey)
        {
            Command = command ?? throw new ArgumentNullException(nameof(command));
        }

        /// <summary>
        /// Gets the market calendar asynchronous.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        /// <returns>Market calendar details.</returns>
        public static async Task<List<TradierMarketCalender>> GetMarketCalendarAsync(Func<TradierMarketCalenderCommand> commandBuilder)
            => await new TradierMarketCalenderRequest(commandBuilder?.Invoke()).GetAsync();

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The list of market calendar.</returns>
        protected override List<TradierMarketCalender> Deserialize(JToken jToken) =>
                SafeListDeserialize<TradierMarketCalender>(jToken, "calendar.days.day");

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>URL for calendar information.</returns>
        protected override string RelativeUrl()
        {
            var relativeUrl = "markets/calendar";
            var @params = new Dictionary<string, string>();
            if (Command.Month.HasValue)
            {
                @params.Add("month", ((int)Command.Month.Value).ToString());
            }

            if (Command.Year.HasValue)
            {
                @params.Add("year", Command.Year.Value.ToString());
            }

            if (@params.Any())
            {
                relativeUrl += "?" + string.Join("&", @params.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value)));
            }

            return relativeUrl;
        }
    }
}