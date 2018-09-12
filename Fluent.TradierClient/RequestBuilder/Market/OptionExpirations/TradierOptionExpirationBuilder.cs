using Fluent.TradierClient.RequestBuilder.Model;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionExpirations
{
    /// <summary>
    /// Option expiration request builder.
    /// </summary>
    /// <seealso cref="Builder{OptionExpirationCommand}" />
    public class TradierOptionExpirationBuilder
        : Builder<TradierOptionExpirationCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierOptionExpirationBuilder"/> class.
        /// </summary>
        /// <param name="requestModel">The request model.</param>
        /// <param name="symbol">The symbol.</param>
        internal TradierOptionExpirationBuilder(AuthToken requestModel, string symbol)
        {
            Command = new TradierOptionExpirationCommand(requestModel, symbol);
        }

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see name="OptionExpirationCommand" />.
        /// </returns>
        protected override TradierOptionExpirationCommand Clone(TradierOptionExpirationCommand cmd)
            => new TradierOptionExpirationCommand(Command, Command.Symbol);
    }
}