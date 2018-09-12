using Fluent.TradierClient.RequestBuilder.Model;

namespace Fluent.TradierClient.RequestBuilder.Market.Search
{
    /// <summary>
    /// Tradier search builder.
    /// </summary>
    /// <seealso cref="Builder{TradierSearchCommand}" />
    public class TradierSearchBuilder
        : Builder<TradierSearchCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierSearchBuilder"/> class.
        /// </summary>
        /// <param name="authToken">The authentication token.</param>
        /// <param name="searchQuery">The search query.</param>
        internal TradierSearchBuilder(AuthToken authToken, string searchQuery)
        {
            Command = new TradierSearchCommand(authToken, searchQuery);
        }

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see name="TradierSearchCommand" />.
        /// </returns>
        protected override TradierSearchCommand Clone(TradierSearchCommand cmd) =>
            new TradierSearchCommand(Command, Command?.SearchQuery);
    }
}