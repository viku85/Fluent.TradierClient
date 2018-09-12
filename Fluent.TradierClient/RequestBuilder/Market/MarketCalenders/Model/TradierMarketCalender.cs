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
        /// The Calendar date.
        /// </summary>
        [JsonProperty("date")]
        public DateTime Date;

        /// <summary>
        /// A textual description of the market status (i.e., 'Market is Closed').
        /// </summary>
        [JsonProperty("description")]
        public string Description;

        /// <summary>
        /// A container node for open hours (only returned on days when market is open).
        /// </summary>
        [JsonProperty("open")]
        public TradierCalendarDayMarketHours Open;

        /// <summary>
        /// A container node for postmarket hours (only returned on days when market is open).
        /// </summary>
        [JsonProperty("postmarket")]
        public TradierCalendarDayMarketHours Postmarket;

        /// <summary>
        /// A container node for premarket hours (only returned on days when market is open).
        /// </summary>
        [JsonProperty("premarket")]
        public TradierCalendarDayMarketHours Premarket;

        /// <summary>
        /// The status of the market on the calendar day (one of: open, closed or holiday).
        /// </summary>
        [JsonProperty("status")]
        public string Status;
    }
}