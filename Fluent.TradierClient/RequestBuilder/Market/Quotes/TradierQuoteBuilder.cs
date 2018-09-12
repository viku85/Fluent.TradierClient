using Fluent.TradierClient.RequestBuilder.Model;
using System.Collections.Generic;

namespace Fluent.TradierClient.RequestBuilder.Market.Quotes
{
    /// <summary>
    /// Tradier Quote builder.
    /// </summary>
    /// <seealso cref="Builder{TradierQuoteCommand}" />
    public class TradierQuoteBuilder
        : Builder<TradierQuoteCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradierQuoteBuilder"/> class.
        /// </summary>
        /// <param name="requestModel">The request model.</param>
        /// <param name="quotes">The quotes.</param>
        internal TradierQuoteBuilder(AuthToken requestModel, List<string> quotes)
            : base()
        {
            Command = new TradierQuoteCommand(requestModel, quotes);
        }

        /// <summary>
        /// Creates a completely new instance of passed <paramref name="cmd" />.
        /// </summary>
        /// <param name="cmd">The existing command.</param>
        /// <returns>
        /// New <see name="TradierQuoteCommand" />.
        /// </returns>
        protected override TradierQuoteCommand Clone(TradierQuoteCommand cmd) =>
            new TradierQuoteCommand(Command) { Quotes = Command.Quotes };
    }
}