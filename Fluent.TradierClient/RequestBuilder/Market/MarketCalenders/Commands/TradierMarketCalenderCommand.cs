using Fluent.TradierClient.RequestBuilder.Model;

namespace Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Commands
{
    /// <summary>
    /// Tradier market calendar command.
    /// </summary>
    /// <seealso cref="AuthToken" />
    public class TradierMarketCalenderCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierMarketCalenderCommand"/> class.
        /// </summary>
        /// <param name="requestModel">The request model.</param>
        internal TradierMarketCalenderCommand(AuthToken requestModel)
            : base(requestModel?.BaseUrl, requestModel?.AccessKey)
        {
        }

        /// <summary>
        /// Gets the month of the calendar requested..
        /// </summary>
        /// <value>
        /// The month of the calendar requested..
        /// </value>
        public Month? Month { get; internal set; }

        /// <summary>
        /// Gets the year of the calendar requested..
        /// </summary>
        /// <value>
        /// The year of the calendar requested..
        /// </value>
        public int? Year { get; internal set; }
    }
}