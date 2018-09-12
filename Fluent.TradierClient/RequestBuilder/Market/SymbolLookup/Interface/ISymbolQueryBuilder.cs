namespace Fluent.TradierClient.RequestBuilder.Market.SymbolLookup.Interface
{
    /// <summary>
    /// Symbol query builder.
    /// </summary>
    public interface ISymbolQueryBuilder
    {
        /// <summary>
        /// Specify the symbol to query.
        /// </summary>
        /// <param name="symbolQuery">The symbol query.</param>
        /// <returns></returns>
        TradierSymbolLookupBuilder WithSymbolQuery(string symbolQuery);
    }
}