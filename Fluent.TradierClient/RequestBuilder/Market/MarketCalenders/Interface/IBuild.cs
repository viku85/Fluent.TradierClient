using Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Commands;

namespace Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Interface
{
    /// <summary>
    /// Market calendar builder.
    /// </summary>
    /// <seealso cref="IBuild{TradierMarketCalenderCommand}" />
    public interface IBuild
        : IBuild<TradierMarketCalenderCommand>
    {
    }
}