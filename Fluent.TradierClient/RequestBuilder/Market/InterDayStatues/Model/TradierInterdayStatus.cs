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
        /// Market date.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date;

        /// <summary>
        /// Text description of market status.
        /// </summary>
        [JsonProperty("description")]
        public string Description;

        /// <summary>
        /// Time when next market state change will occur.
        /// </summary>
        [JsonProperty("next_change")]
        public DateTime NextChange;

        /// <summary>
        /// The Next market state.
        /// </summary>
        [JsonProperty("next_state")]
        public string NextState;

        /// <summary>
        /// Current market state.
        /// </summary>
        [JsonProperty("state")]
        public string State;

        /// <summary>
        /// The Current timestamp represented as a Unix epoch.
        /// </summary>
        [JsonProperty("timestamp")]
        public long TimeStamp;
    }
}