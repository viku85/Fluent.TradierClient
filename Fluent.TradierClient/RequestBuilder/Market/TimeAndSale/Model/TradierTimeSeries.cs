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
        /// Gets or sets the Time
        /// </summary>
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets last price for the time-series interval
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets opening price
        /// </summary>
        [JsonProperty("open")]
        public decimal Open { get; set; }

        /// <summary>
        /// Gets or sets trading day high
        /// </summary>
        [JsonProperty("high")]
        public decimal High { get; set; }

        /// <summary>
        /// Gets or sets trading day low
        /// </summary>
        [JsonProperty("low")]
        public decimal Low { get; set; }

        /// <summary>
        /// Gets or sets closing price
        /// </summary>
        [JsonProperty("close")]
        public decimal Close { get; set; }

        /// <summary>
        /// Gets or sets total volume for the time-series interval
        /// </summary>
        [JsonProperty("volume")]
        public long Volume { get; set; }
    }
}