using Fluent.TradierClient.RequestBuilder.Market.Quotes.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.Quotes
{
    /// <summary>
    /// Tradier Quote request.
    /// </summary>
    /// <seealso cref="TradierWebRequest{List{TradierQuote}}" />
    public class TradierQuoteRequest
        : TradierWebRequest<List<TradierQuote>>
    {
        /// <summary>
        /// The command
        /// </summary>
        private readonly TradierQuoteCommand Command;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierQuoteRequest"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <exception cref="ArgumentNullException">command</exception>
        protected TradierQuoteRequest(TradierQuoteCommand command)
            : base(command?.BaseUrl, command?.AccessKey)
        {
            Command = command ?? throw new ArgumentNullException(nameof(command));
        }

        /// <summary>
        /// Gets the Quotes asynchronous.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        /// <returns>Instance of <see cref="TradierQuoteRequest"/>.</returns>
        public static async Task<List<TradierQuote>> GetQuoteAsync(Func<TradierQuoteCommand> commandBuilder)
            => await new TradierQuoteRequest(commandBuilder()).GetAsync();

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The list of qoutes.</returns>
        protected override List<TradierQuote> Deserialize(JToken jToken)
                    => SafeListDeserialize<TradierQuote>(jToken, "quotes.quote");

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>URL for getting quotes.</returns>
        protected override string RelativeUrl() => "markets/quotes?symbols=" + string.Join(',', Command.Quotes);
    }
}