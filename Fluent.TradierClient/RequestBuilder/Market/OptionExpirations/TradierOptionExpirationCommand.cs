using Fluent.TradierClient.RequestBuilder.Model;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionExpirations
{
    /// <summary>
    /// Option expiration command.
    /// </summary>
    /// <seealso cref="AuthToken" />
    public class TradierOptionExpirationCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionExpirationCommand"/> class.
        /// </summary>
        /// <param name="model">The model.</param>
        internal TradierOptionExpirationCommand(AuthToken model)
            : base(model?.BaseUrl, model?.AccessKey)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionExpirationCommand"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="symbol">The symbol.</param>
        internal TradierOptionExpirationCommand(AuthToken token, string symbol)
            : this(token)
        {
            Symbol = symbol;
        }

        /// <summary>
        /// Gets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get; }
    }
}