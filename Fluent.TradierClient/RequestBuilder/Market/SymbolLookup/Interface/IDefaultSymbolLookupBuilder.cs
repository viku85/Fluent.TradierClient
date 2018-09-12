namespace Fluent.TradierClient.RequestBuilder.Market.SymbolLookup.Interface
{
    /// <summary>
    /// Default Lookup builder.
    /// </summary>
    /// <seealso cref="IExchangeFilterBuilder" />
    /// <seealso cref="ISymbolQueryBuilder" />
    /// <seealso cref="ITypeFilterBuilder" />
    public interface IDefaultSymbolLookupBuilder
        : IExchangeFilterBuilder, ISymbolQueryBuilder, ITypeFilterBuilder
    {
    }
}