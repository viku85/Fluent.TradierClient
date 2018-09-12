using Newtonsoft.Json;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Model
{
    /// <summary>
    /// One bar of historical Tradier data.
    /// </summary>
    public class TradierTimeSeries
    {
        /// <summary>
        /// The Time
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time;

        /// <summary>
        /// Last price for the time-series interval
        /// </summary>
        [JsonProperty("price")]
        public decimal Price;

        /// <summary>
        /// Opening price
        /// </summary>
        [JsonProperty("open")]
        public decimal Open;

        /// <summary>
        /// Trading day high
        /// </summary>
        [JsonProperty("high")]
        public decimal High;

        /// <summary>
        /// Trading day low
        /// </summary>
        [JsonProperty("low")]
        public decimal Low;

        /// <summary>
        /// Closing price
        /// </summary>
        [JsonProperty("close")]
        public decimal Close;

        /// <summary>
        /// Total volume for the time-series interval
        /// </summary>
        [JsonProperty("volume")]
        public long Volume;
    }
}