namespace Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Interface
{
    /// <summary>
    /// Historical default builder option.
    /// </summary>
    /// <seealso cref="IInterval" />
    /// <seealso cref="IStartDate" />
    /// <seealso cref="IBuild" />
    public interface IDefaultOptionBuilder
        : IIntervalBuilder, IStartDateBuilder, IBuild
    {
    }
}