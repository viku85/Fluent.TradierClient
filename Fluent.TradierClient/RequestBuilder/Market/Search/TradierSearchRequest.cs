using Fluent.TradierClient.RequestBuilder.Market.Search.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.Search
{
    /// <summary>
    /// Tradier search request.
    /// </summary>
    /// <seealso cref="TradierWebRequest{List{TradierSearchResult}}" />
    public class TradierSearchRequest
        : TradierWebRequest<List<TradierSearchResult>>
    {
        /// <summary>
        /// The command
        /// </summary>
        private readonly TradierSearchCommand Command;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierSearchRequest"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <exception cref="ArgumentNullException">command</exception>
        internal TradierSearchRequest(TradierSearchCommand command)
            : base(command?.BaseUrl, command?.AccessKey)
        {
            Command = command ?? throw new ArgumentNullException(nameof(command));
        }

        /// <summary>
        /// Gets the search result asynchronous.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        /// <returns></returns>
        public static async Task<List<TradierSearchResult>> GetSearchResultAsync(Func<TradierSearchCommand> commandBuilder)
            => await new TradierSearchRequest(commandBuilder()).GetAsync();

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The list of search result.</returns>
        protected override List<TradierSearchResult> Deserialize(JToken jToken) =>
            SafeListDeserialize<TradierSearchResult>(jToken, "securities.security");

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>URL for company search.</returns>
        protected override string RelativeUrl()
        {
            return $"markets/search?q={Command.SearchQuery}";
        }
    }
}