namespace Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Interface
{
    /// <summary>
    /// Default market calendar builder option.
    /// </summary>
    /// <seealso cref="IBuild" />
    /// <seealso cref="IMonthBuilder" />
    /// <seealso cref="IYearBuilder" />
    public interface IDefaultCalendarBuilder
        : IMonthBuilder, IYearBuilder
    {
    }
}