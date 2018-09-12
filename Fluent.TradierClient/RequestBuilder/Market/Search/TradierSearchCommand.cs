using Fluent.TradierClient.RequestBuilder.Model;

namespace Fluent.TradierClient.RequestBuilder.Market.Search
{
    /// <summary>
    /// Tradier search command.
    /// </summary>
    /// <seealso cref="Fluent.TradierClient.RequestBuilder.Model.AuthToken" />
    public class TradierSearchCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierSearchCommand"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="searchQuery">The search query.</param>
        internal TradierSearchCommand(AuthToken token, string searchQuery)
            : base(token?.BaseUrl, token?.AccessKey)
        {
            SearchQuery = searchQuery;
        }

        /// <summary>
        /// Gets the keyword to search.
        /// </summary>
        /// <value>
        /// The keyword to search.
        /// </value>
        public string SearchQuery { get; }
    }
}