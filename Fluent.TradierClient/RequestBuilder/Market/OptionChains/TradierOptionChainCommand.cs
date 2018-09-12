using Fluent.TradierClient.RequestBuilder.Model;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionChains
{
    /// <summary>
    /// Option chain command.
    /// </summary>
    /// <seealso cref="AuthToken" />
    public class TradierOptionChainCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionChainCommand"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        internal TradierOptionChainCommand(AuthToken token)
            : base(token?.BaseUrl, token?.AccessKey)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionChainCommand"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="symbol">The symbol.</param>
        /// <param name="expiry">The expiry.</param>
        internal TradierOptionChainCommand(AuthToken token, string symbol, DateTime expiry)
            : this(token)
        {
            Symbol = symbol;
            Expiry = expiry;
        }

        /// <summary>
        /// Gets or sets The expiration date to obtain an option chain.
        /// </summary>
        /// <value>
        /// The expiration date to obtain an option chain.
        /// </value>
        public DateTime Expiry { get; internal set; }

        /// <summary>
        /// Gets the expiry date range limit.
        /// </summary>
        /// <value>
        /// The expiry date range limit.
        /// </value>
        public int? ExpiryDateRangeLimit { get; internal set; }

        /// <summary>
        /// Gets or sets the requested symbol.
        /// </summary>
        /// <value>
        /// The requested symbol.
        /// </value>
        public string Symbol { get; internal set; }
    }
}