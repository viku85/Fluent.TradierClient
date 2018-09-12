using Newtonsoft.Json;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Model
{
    /// <summary>
    /// Market calendar hours
    /// </summary>
    public class TradierCalendarDayMarketHours
    {
        /// <summary>
        /// Gets or sets the start time for the premarket/open/postmarket time range.
        /// </summary>
        [JsonProperty("start")]
        public DateTime Start { get; set; }

        /// <summary>
        /// Gets or sets the end time for the premarket/open/postmarket time range.
        /// </summary>
        [JsonProperty("end")]
        public DateTime End { get; set; }
    }
}