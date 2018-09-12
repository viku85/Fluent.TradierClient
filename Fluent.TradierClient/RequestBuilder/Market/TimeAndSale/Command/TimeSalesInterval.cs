using System.Runtime.Serialization;

namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale
{
    /// <summary>
    /// The interval of time for timesales pricing
    /// </summary>
    public enum TimeSalesInterval
    {
        /// <summary>
        /// One of tick
        /// </summary>
        Tick,

        /// <summary>
        /// One minute interval.
        /// </summary>
        [EnumMember(Value = "1min")]
        OneMin,

        /// <summary>
        /// Five minute interval.
        /// </summary>
        [EnumMember(Value = "5min")]
        FiveMin,

        /// <summary>
        /// The fifteen minute interval.
        /// </summary>
        [EnumMember(Value = "15min")]
        FifteenMin
    }
}