using Fluent.TradierClient.RequestBuilder.Market.SymbolLookup.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.SymbolLookup
{
    /// <summary>
    /// Traider symbol lookup request.
    /// </summary>
    /// <seealso cref="TradierWebRequest{List{TradierSymbolLookup}}" />
    public class TradierSymbolLookupRequest
        : TradierWebRequest<List<TradierSymbolLookup>>
    {
        /// <summary>
        /// The command
        /// </summary>
        private readonly TradierSymbolLookupCommand Command;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierSymbolLookupRequest"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <exception cref="ArgumentNullException">command</exception>
        protected TradierSymbolLookupRequest(TradierSymbolLookupCommand command)
            : base(command?.BaseUrl, command.AccessKey)
        {
            Command = command ?? throw new ArgumentNullException(nameof(command));
        }

        /// <summary>
        /// Gets the lookup result asynchronous.
        /// </summary>
        /// <param name="commandComposer">The command composer.</param>
        /// <returns>Instance of <see cref="TradierSymbolLookupRequest"/>.</returns>
        public static async Task<List<TradierSymbolLookup>> GetLookupResultAsync(Func<TradierSymbolLookupCommand> commandComposer)
            => await new TradierSymbolLookupRequest(commandComposer?.Invoke()).GetAsync();

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The list of system lookup.</returns>
        protected override List<TradierSymbolLookup> Deserialize(JToken jToken) =>
                SafeListDeserialize<TradierSymbolLookup>(jToken, "securities.security");

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>Request URL for symbol lookup.</returns>
        protected override string RelativeUrl()
        {
            var relativeUrl = "markets/lookup";
            var parms = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(Command.Query))
            {
                parms.Add("q", Command.Query);
            }

            if (Command.Exchanges.Any())
            {
                parms.Add("exchanges", string.Join(',', Command.Exchanges.Distinct()));
            }

            if (Command.Types.Any())
            {
                parms.Add("types", string.Join(",", Command.Types.Distinct()));
            }

            if (parms.Any())
            {
                relativeUrl += "?" + string.Join("&", parms.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value)));
            }

            return relativeUrl;
        }
    }
}