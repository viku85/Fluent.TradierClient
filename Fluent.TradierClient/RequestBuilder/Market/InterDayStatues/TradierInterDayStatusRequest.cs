using Fluent.TradierClient.RequestBuilder.Market.InterDayStatues.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.InterDayStatues
{
    /// <summary>
    /// Tradier market inter-day status.
    /// </summary>
    /// <seealso cref="TradierWebRequest{TradierInterdayStatus}" />
    public class TradierInterDayStatusRequest
        : TradierWebRequest<TradierInterdayStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierInterDayStatusRequest"/> class.
        /// </summary>
        /// <param name="tradierInterdayCommand">The tradier interday command.</param>
        private TradierInterDayStatusRequest(TradierInterDayCommand tradierInterdayCommand)
            : base(tradierInterdayCommand?.BaseUrl, tradierInterdayCommand?.AccessKey)
        {
        }

        /// <summary>
        /// Gets the market status asynchronous.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        /// <returns>inter day status</returns>
        public static async Task<TradierInterdayStatus> GetMarketStatusAsync(Func<TradierInterDayCommand> commandBuilder)
                    => await new TradierInterDayStatusRequest(commandBuilder()).GetAsync();

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The inter day status.</returns>
        protected override TradierInterdayStatus Deserialize(JToken jToken)
            => jToken?.SelectToken("clock").ToObject<TradierInterdayStatus>();

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>URL for market inter-day status.</returns>
        protected override string RelativeUrl() =>
            "markets/clock";
    }
}