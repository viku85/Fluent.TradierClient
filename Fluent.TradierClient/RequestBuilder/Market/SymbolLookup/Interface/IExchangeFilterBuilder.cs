namespace Fluent.TradierClient.RequestBuilder.Market.SymbolLookup.Interface
{
    /// <summary>
    /// Exchange filter builder.
    /// </summary>
    public interface IExchangeFilterBuilder
    {
        /// <summary>
        /// Specify list of exchange codes to query.
        /// </summary>
        /// <param name="exchangeOption">The exchange option.</param>
        /// <returns></returns>
        TradierSymbolLookupBuilder WithExchangeFilter(params string[] exchangeOption);
    }
}