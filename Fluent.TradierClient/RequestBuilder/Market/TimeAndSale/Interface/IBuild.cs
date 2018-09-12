namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Interface
{
    /// <summary>
    /// The default build for Time sales command.
    /// </summary>
    /// <seealso cref="IBuild{TimeSaleCommand}" />
    public interface IBuild
        : IBuild<TradierTimeSaleCommand>
    {
    }
}