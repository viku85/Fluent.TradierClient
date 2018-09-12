using Newtonsoft.Json;

namespace Fluent.TradierClient.RequestBuilder.Market.OptionChains.Model
{
    /// <summary>
    /// Tradier option chain result.
    /// </summary>
    public class TradierOptionChain
    {
        /// <summary>
        /// Gets or sets the Current ask.
        /// </summary>
        /// <value>
        /// The Current ask.
        /// </value>
        [JsonProperty("ask")]
        public decimal? Ask { get; set; }

        /// <summary>
        /// Gets or sets the Current bid.
        /// </summary>
        /// <value>
        /// The Current bid.
        /// </value>
        [JsonProperty("bid")]
        public decimal? Bid { get; set; }

        /// <summary>
        /// Gets or sets the Daily net change.
        /// </summary>
        /// <value>
        /// The Daily net change.
        /// </value>
        [JsonProperty("change")]
        public decimal? Change { get; set; }

        /// <summary>
        /// Gets or sets the Last price.
        /// </summary>
        /// <value>
        /// The Last price.
        /// </value>
        [JsonProperty("last")]
        public decimal? Last { get; set; }

        /// <summary>
        /// Gets or sets the Current open interest.
        /// </summary>
        /// <value>
        /// The Current open interest.
        /// </value>
        [JsonProperty("open_interest")]
        public decimal? OpenInterest { get; set; }

        /// <summary>
        /// Gets or sets the Option strike price.
        /// </summary>
        /// <value>
        /// The Option strike price.
        /// </value>
        [JsonProperty("strike")]
        public decimal? Strike { get; set; }

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
    }
}