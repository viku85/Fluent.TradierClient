using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale
{
    /// <summary>
    /// Time and sales command.
    /// </summary>
    /// <seealso cref="AuthToken" />
    public class TradierTimeSaleCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierTimeSaleCommand"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        internal TradierTimeSaleCommand(AuthToken model)
            : base(model?.BaseUrl, model?.AccessKey)
        {
        }

        /// <summary>
        /// Gets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get; internal set; }

        /// <summary>
        /// Gets the interval of time for timesales pricing.
        /// </summary>
        /// <value>
        /// The interval of time for timesales pricing.
        /// </value>
        public TimeSalesInterval? Interval { get; internal set; }

        /// <summary>
        /// Gets the start datetime for timesales range.
        /// </summary>
        /// <value>
        /// The start datetime for timesales range.
        /// </value>
        public DateTime? StartDate { get; internal set; }

        /// <summary>
        /// Gets the end datetime for timesales range.
        /// </summary>
        /// <value>
        /// The end datetime for timesales range.
        /// </value>
        public DateTime? EndDate { get; internal set; }

        /// <summary>
        /// Gets the session conditions to request data from Tradier.
        /// </summary>
        /// <value>
        /// The session conditions to requetst data for.
        /// </value>
        public SessionFilter? SessionFilter { get; internal set; }
    }
}