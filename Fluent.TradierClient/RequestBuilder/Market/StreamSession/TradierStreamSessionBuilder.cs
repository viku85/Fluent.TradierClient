using Fluent.TradierClient.RequestBuilder.Model;

namespace Fluent.TradierClient.RequestBuilder.Market.StreamSession
{
    /// <summary>
    /// Tradier stream session builder.
    /// </summary>
    /// <seealso cref="Builder{TradierStreamSessionCommand}" />
    public class TradierStreamSessionBuilder
        : Builder<TradierStreamSessionCommand>
    {
        internal TradierStreamSessionBuilder(AuthToken authToken)
        {
            Command = new TradierStreamSessionCommand(authToken?.BaseUrl, authToken?.AccessKey);
        }

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see name="TradierStreamSessionCommand" />.
        /// </returns>
        protected override TradierStreamSessionCommand Clone(TradierStreamSessionCommand cmd) =>
            new TradierStreamSessionCommand(cmd?.BaseUrl, cmd?.AccessKey);
    }
}