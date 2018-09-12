using Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings;
using Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Interface;
using Fluent.TradierClient.RequestBuilder.Market.InterDayStatues;
using Fluent.TradierClient.RequestBuilder.Market.MarketCalenders;
using Fluent.TradierClient.RequestBuilder.Market.OptionChains;
using Fluent.TradierClient.RequestBuilder.Market.OptionChains.Interface;
using Fluent.TradierClient.RequestBuilder.Market.OptionExpirations;
using Fluent.TradierClient.RequestBuilder.Market.OptionStrikes;
using Fluent.TradierClient.RequestBuilder.Market.OptionStrikes.Interface;
using Fluent.TradierClient.RequestBuilder.Market.Quotes;
using Fluent.TradierClient.RequestBuilder.Market.Search;
using Fluent.TradierClient.RequestBuilder.Market.StreamSession;
using Fluent.TradierClient.RequestBuilder.Market.SymbolLookup;
using Fluent.TradierClient.RequestBuilder.Market.SymbolLookup.Interface;
using Fluent.TradierClient.RequestBuilder.Market.TimeAndSale;
using Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Interface;
using Fluent.TradierClient.RequestBuilder.Model;
using System;
using System.Linq;

namespace Fluent.TradierClient.RequestBuilder.Market
{
    /// <summary>
    /// Market builder for Tradier.
    /// </summary>
    public class TradierMarketBuilder
    {
        /// <summary>
        /// The authentication token
        /// </summary>
        private readonly AuthToken AuthToken;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierMarketBuilder"/> class.
        /// </summary>
        /// <param name="requestModel">The request model.</param>
        /// <exception cref="ArgumentNullException">requestModel</exception>
        internal TradierMarketBuilder(AuthToken requestModel)
        {
            AuthToken = requestModel ?? throw new ArgumentNullException(nameof(requestModel));
        }

        /// <summary>
        /// Creates the new session for streaming.
        /// </summary>
        /// <returns>Stream session builder.</returns>
        public TradierStreamSessionBuilder CreateSession() => new TradierStreamSessionBuilder(AuthToken);

        /// <summary>
        /// Gets a new Historical pricing builder.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <returns>The pricing builder.</returns>
        public IDefaultOptionBuilder ForHistoricalData(string symbol) => new TradierHistoricalPricingBuilder(AuthToken, symbol);

        /// <summary>
        /// Gets a new Market calendar builder.
        /// </summary>
        /// <returns>The Market calendar builder.</returns>
        public TradierMarketCalenderBuilder ForMarketCalendar() => new TradierMarketCalenderBuilder(AuthToken);

        /// <summary>
        /// Gets a new Market status builder.
        /// </summary>
        /// <returns>Market status builder</returns>
        public TradierInterdayStatusBuilder ForInterDayStatus() => new TradierInterdayStatusBuilder(AuthToken);

        /// <summary>
        /// Get a new Option chain builder.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <returns>The option chain builder.</returns>
        public IDefaultBuilder ForOptionChain(string symbol) => new TradierOptionChainBuilder(AuthToken, symbol);

        /// <summary>
        /// Gets a new Option expiry builder.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <returns>The option expiry builder.</returns>
        public TradierOptionExpirationBuilder ForOptionExpiry(string symbol) => new TradierOptionExpirationBuilder(AuthToken, symbol);

        /// <summary>
        /// Gets a new option strike builder.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <returns>The option strike builder.</returns>
        public IDefaultExpiryOptionBuilder ForOptionStrike(string symbol) => new TradierOptionStrikeBuilder(AuthToken, symbol);

        /// <summary>
        /// Gets a new Quote builder.
        /// </summary>
        /// <param name="quotes">The quotes.</param>
        /// <returns>The Quote builder.</returns>
        public TradierQuoteBuilder ForQuotes(params string[] quotes) => new TradierQuoteBuilder(AuthToken, quotes.ToList());

        /// <summary>
        /// Gets a new symbol lookup builder.
        /// </summary>
        /// <returns>The new symbol look up builder.</returns>
        public IDefaultSymbolLookupBuilder ForSymbolLookup() => new TradierSymbolLookupBuilder(AuthToken);

        /// <summary>
        /// Gets a new Time sale builder.
        /// </summary>
        /// <returns>The new Time sale builder.</returns>
        public IDefaultTimeSaleBuilder ForTimeSale() => new TradierTimeSaleBuilder(AuthToken);

        /// <summary>
        /// Gets a new Search query builder.
        /// </summary>
        /// <param name="searchKeyword">The search keyword.</param>
        /// <returns>The search query builder.</returns>
        public TradierSearchBuilder WithSearchQuery(string searchKeyword) => new TradierSearchBuilder(AuthToken, searchKeyword);
    }
}