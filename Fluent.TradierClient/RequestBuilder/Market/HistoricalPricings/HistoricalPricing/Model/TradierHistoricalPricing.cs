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
        /// Closing price for the requested interval.
        /// </summary>
        [JsonProperty("close")]
        public decimal Close;

        /// <summary>
        /// High price for the requested interval.
        /// </summary>
        [JsonProperty("high")]
        public decimal High;

        /// <summary>
        /// Low price for the requested interval.
        /// </summary>
        [JsonProperty("low")]
        public decimal Low;

        /// <summary>
        /// Opening price for the requested interval
        /// </summary>
        [JsonProperty("open")]
        public decimal Open;

        /// <summary>
        /// Date for historical data.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Time;

        /// <summary>
        /// Daily volume.
        /// </summary>
        [JsonProperty("volume")]
        public long Volume;
    }
}