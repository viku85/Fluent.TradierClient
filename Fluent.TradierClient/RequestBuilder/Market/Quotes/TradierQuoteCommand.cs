using Fluent.TradierClient.RequestBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fluent.TradierClient.RequestBuilder.Market.Quotes
{
    /// <summary>
    /// Tradier Quote command.
    /// </summary>
    /// <seealso cref="AuthToken" />
    public class TradierQuoteCommand
        : AuthToken
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierQuoteCommand"/> class.
        /// </summary>
        /// <param name="token">The token.</param>
        internal TradierQuoteCommand(AuthToken token)
            : base(token.BaseUrl, token.AccessKey)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierQuoteCommand"/> class.
        /// </summary>
        /// <param name="requestModel">The request model.</param>
        /// <param name="quotes">The quotes.</param>
        /// <exception cref="ArgumentException">quotes</exception>
        internal TradierQuoteCommand(AuthToken requestModel, List<string> quotes)
            : this(requestModel)
        {
            var diffChecker = new HashSet<string>();
            if (quotes == null || !quotes.All(diffChecker.Add))
            {
                throw new ArgumentException(nameof(quotes));
            }

            Quotes = quotes;
        }

        /// <summary>
        /// Gets the Quotes.
        /// </summary>
        /// <value>
        /// The Quotes.
        /// </value>
        public List<string> Quotes { get; internal set; }
    }
}