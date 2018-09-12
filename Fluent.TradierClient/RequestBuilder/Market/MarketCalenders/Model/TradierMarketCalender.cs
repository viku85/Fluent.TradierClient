using Newtonsoft.Json;
using System;

namespace Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Model
{
    /// <summary>
    /// Tradier market calendar response.
    /// </summary>
    public class TradierMarketCalender
    {
        /// <summary>
        /// Gets or sets the Calendar date.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets a textual description of the market status (i.e., 'Market is Closed').
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a container node for open hours (only returned on days when market is open).
        /// </summary>
        [JsonProperty("open")]
        public TradierCalendarDayMarketHours Open { get; set; }

        /// <summary>
        /// Gets or sets a container node for postmarket hours (only returned on days when market is open).
        /// </summary>
        [JsonProperty("postmarket")]
        public TradierCalendarDayMarketHours Postmarket { get; set; }

        /// <summary>
        /// Gets or sets a container node for premarket hours (only returned on days when market is open).
        /// </summary>
        [JsonProperty("premarket")]
        public TradierCalendarDayMarketHours Premarket { get; set; }

        /// <summary>
        /// Gets or sets the status of the market on the calendar day (one of: open, closed or holiday).
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}