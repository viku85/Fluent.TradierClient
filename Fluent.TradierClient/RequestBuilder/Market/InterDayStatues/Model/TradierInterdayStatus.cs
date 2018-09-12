using Newtonsoft.Json;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.InterDayStatues.Model
{
    /// <summary>
    /// Market inter-day status.
    /// </summary>
    public class TradierInterdayStatus
    {
        /// <summary>
        /// Gets or sets market date.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets text description of market status.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets time when next market state change will occur.
        /// </summary>
        [JsonProperty("next_change")]
        public DateTime NextChange { get; set; }

        /// <summary>
        /// Gets or sets the Next market state.
        /// </summary>
        [JsonProperty("next_state")]
        public string NextState { get; set; }

        /// <summary>
        /// Gets or sets current market state.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the Current timestamp represented as a Unix epoch.
        /// </summary>
        [JsonProperty("timestamp")]
        public long TimeStamp { get; set; }
    }
}