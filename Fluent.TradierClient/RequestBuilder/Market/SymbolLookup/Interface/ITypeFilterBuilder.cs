namespace Fluent.TradierClient.RequestBuilder.Market.SymbolLookup.Interface
{
    /// <summary>
    /// Symbol type filter builder.
    /// </summary>
    public interface ITypeFilterBuilder
    {
        /// <summary>
        /// Specify list of security types to query.
        /// </summary>
        /// <param name="typeOptions">The type options.</param>
        /// <returns></returns>
        TradierSymbolLookupBuilder WithTypeFilter(params string[] typeOptions);
    }
}