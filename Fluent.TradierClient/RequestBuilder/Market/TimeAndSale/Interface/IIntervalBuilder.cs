namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Interface
{
    /// <summary>
    /// Time sale interval builder.
    /// </summary>
    /// <seealso cref="IBuild" />
    public interface IIntervalBuilder
        : IBuild
    {
        /// <summary>
        /// Specify the interval of time for timesales pricing
        /// </summary>
        /// <param name="interval">The interval.</param>
        /// <returns>Time Sale builder for start date.</returns>
        IStartDateBuilder WithInterval(TimeSalesInterval interval);
    }
}