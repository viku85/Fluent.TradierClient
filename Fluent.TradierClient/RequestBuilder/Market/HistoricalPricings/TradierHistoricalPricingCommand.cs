using Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Model;
using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings
{
    /// <summary>
    /// Tradier historical pricing.
    /// </summary>
    /// <seealso cref="AuthToken" />
    public class TradierHistoricalPricingCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierHistoricalPricingCommand"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        internal TradierHistoricalPricingCommand(AuthToken token)
            : base(token?.BaseUrl, token?.AccessKey)
        {
        }

        /// <summary>
        /// Gets the end date for history range .
        /// </summary>
        /// <value>
        /// The end date for history range .
        /// </value>
        public DateTime? EndDate { get; internal set; }

        /// <summary>
        /// Gets the interval of time for historical pricing; One of daily, weekly or monthly (default: daily).
        /// </summary>
        /// <value>
        /// The interval.
        /// </value>
        public HistoryIntervalOption? Interval { get; internal set; }

        /// <summary>
        /// Gets the start date for history range.
        /// </summary>
        /// <value>
        /// The start date for history range.
        /// </value>
        public DateTime? StartDate { get; internal set; }

        /// <summary>
        /// Gets the requested symbol.
        /// </summary>
        /// <value>
        /// The requested symbol.
        /// </value>
        public string Symbol { get; internal set; }
    }
}