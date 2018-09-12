using Fluent.TradierClient.RequestBuilder.Model;
using System.Collections.Generic;

namespace Fluent.TradierClient.RequestBuilder.Market.SymbolLookup
{
    /// <summary>
    /// Tradier symbol lookup command.
    /// </summary>
    /// <seealso cref="AuthToken" />
    public class TradierSymbolLookupCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierSymbolLookupCommand"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        internal TradierSymbolLookupCommand(AuthToken token)
            : base(token?.BaseUrl, token?.AccessKey)
        {
            Exchanges = new List<string>();
            Types = new List<string>();
        }

        /// <summary>
        /// Gets or sets the symbol or partial symbol to look up.
        /// </summary>
        /// <value>
        /// The symbol or partial symbol to look up.
        /// </value>
        public string Query { get; internal set; }

        /// <summary>
        /// Gets or sets the list of exchange codes to query.
        /// </summary>
        /// <value>
        /// The list of exchange codes to query.
        /// </value>
        public List<string> Exchanges { get; internal set; }

        /// <summary>
        /// Gets the list of security types to query.
        /// </summary>
        /// <value>
        /// The list of security types to query.
        /// </value>
        public List<string> Types { get; internal set; }
    }
}