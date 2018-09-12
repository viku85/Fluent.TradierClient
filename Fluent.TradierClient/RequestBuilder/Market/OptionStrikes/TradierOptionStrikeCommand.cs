using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionStrikes
{
    /// <summary>
    /// Tradier option strike command.
    /// </summary>
    /// <seealso cref="AuthToken" />
    public class TradierOptionStrikeCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionStrikeCommand"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        internal TradierOptionStrikeCommand(AuthToken token)
            : base(token.BaseUrl, token.AccessKey)
        {
        }

        /// <summary>
        /// Gets or sets the expiration date to obtain strikes.
        /// </summary>
        /// <value>
        /// The expiration date to obtain strikes
        /// </value>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Gets the expiry date range limit for auto expiry generation.
        /// </summary>
        /// <value>
        /// The expiry date range limit for auto expiry generation.
        /// </value>
        public int? ExpiryDateRangeLimit { get; internal set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get; set; }
    }
}