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
        /// The start time for the premarket/open/postmarket time range.
        /// </summary>
        [JsonProperty("start")]
        public DateTime Start;

        /// <summary>
        /// The end time for the premarket/open/postmarket time range.
        /// </summary>
        [JsonProperty("end")]
        public DateTime End;
    }
}