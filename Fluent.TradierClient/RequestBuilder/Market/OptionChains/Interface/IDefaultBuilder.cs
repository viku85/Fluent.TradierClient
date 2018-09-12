namespace Fluent.TradierClient.RequestBuilder.Market.OptionChains.Interface
{
    /// <summary>
    /// Default builder for Option chain.
    /// </summary>
    /// <seealso cref="IExpiryBuilder" />
    /// <seealso cref="IAutoExpiryLimitBuilder" />
    public interface IDefaultBuilder
        : IExpiryBuilder, IAutoExpiryLimitBuilder
    {
    }
}