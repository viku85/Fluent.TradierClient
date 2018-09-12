using Newtonsoft.Json;
using System;

namespace Fluent.TradierClient.RequestBuilder.HistoricalPricings.HistoricalPricing.Model
{
    /// <summary>
    /// "Bar" for a history unit.
    /// </summary>
    public class TradierHistoricalPricing
    {
        /// <summary>
        /// Gets or sets closing price for the requested interval.
        /// </summary>
        [JsonProperty("close")]
        public decimal Close { get; set; }

        /// <summary>
        /// Gets or sets high price for the requested interval.
        /// </summary>
        [JsonProperty("high")]
        public decimal High { get; set; }

        /// <summary>
        /// Gets or sets low price for the requested interval.
        /// </summary>
        [JsonProperty("low")]
        public decimal Low { get; set; }

        /// <summary>
        /// Gets or sets opening price for the requested interval
        /// </summary>
        [JsonProperty("open")]
        public decimal Open { get; set; }

        /// <summary>
        /// Gets or sets date for historical data.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets daily volume.
        /// </summary>
        [JsonProperty("volume")]
        public long Volume { get; set; }
    }
}