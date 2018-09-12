using Newtonsoft.Json;

namespace Fluent.TradierClient.RequestBuilder.Market.Quotes.Model
{
    /// <summary>
    /// Tradier quote model.
    /// </summary>
    public class TradierQuote
    {
        /// <summary>
        /// Gets or sets the Opening price.
        /// </summary>
        [JsonProperty("open")]
        public decimal? Open { get; set; } = 0;

        /// <summary>
        /// Gets or sets the 52 week high.
        /// </summary>
        [JsonProperty("week_52_high")]
        public decimal Week52High { get; set; }

        /// <summary>
        /// Gets or sets the Current ask.
        /// </summary>
        [JsonProperty("ask")]
        public decimal Ask { get; set; }

        /// <summary>
        /// Gets or sets the Date and time of current ask.
        /// </summary>
        [JsonProperty("ask_date")]
        public long AskDateUnix { get; set; }

        /// <summary>
        /// Gets or sets the Exchange of ask.
        /// </summary>
        [JsonProperty("askexch")]
        public string AskExchange { get; set; }

        /// <summary>
        /// Gets or sets the Size of ask.
        /// </summary>
        [JsonProperty("asksize")]
        public decimal AskSize { get; set; }

        /// <summary>
        /// Gets or sets the Average daily volume.
        /// </summary>
        [JsonProperty("average_volume")]
        public decimal AverageVolume { get; set; }

        /// <summary>
        /// Gets or sets the Current bid.
        /// </summary>
        [JsonProperty("bid")]
        public decimal Bid { get; set; }

        /// <summary>
        /// Gets or sets the Date and time of current bid.
        /// </summary>
        [JsonProperty("bid_date")]
        public long BidDateUnix { get; set; }

        /// <summary>
        /// Gets or sets the Size of bid.
        /// </summary>
        [JsonProperty("bidsize")]
        public decimal BidSize { get; set; }

        /// <summary>
        /// Gets or sets the Exchange of bid.
        /// </summary>
        [JsonProperty("bidexch")]
        public string BigExchange { get; set; }

        /// <summary>
        /// Gets or sets the Daily net change.
        /// </summary>
        [JsonProperty("change")]
        public decimal Change { get; set; }

        /// <summary>
        /// Gets or sets the Closing price.
        /// </summary>
        [JsonProperty("close")]
        public decimal? Close { get; set; }

        /// <summary>
        /// Gets or sets the Symbol description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Quote Exchange.
        /// </summary>
        [JsonProperty("exch")]
        public string Exchange { get; set; }

        /// <summary>
        /// Gets or sets the Trading day high.
        /// </summary>
        [JsonProperty("high")]
        public decimal? High { get; set; }

        /// <summary>
        /// Gets or sets the last price.
        /// </summary>
        /// <value>
        /// The last price.
        /// </value>
        [JsonProperty("last")]
        public decimal Last { get; set; }

        /// <summary>
        /// Gets or sets the Last incremental volume.
        /// </summary>
        [JsonProperty("last_volume")]
        public decimal LastVolume { get; set; }

        /// <summary>
        /// Gets or sets theTrading day low
        /// </summary>
        [JsonProperty("low")]
        public decimal? Low { get; set; }

        /// <summary>
        /// Gets or sets the Size of the contract in shares.
        /// </summary>
        [JsonProperty("contract_size")]
        public int OptionsContractSize { get; set; }

        /// <summary>
        /// Gets or sets the Date of expiration.
        /// </summary>
        [JsonProperty("expiration_date")]
        public long OptionsExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets the Type of expiration.
        /// </summary>
        [JsonProperty("expiration_type")]
        public TradierOptionExpirationType OptionsExpirationType { get; set; }

        /// <summary>
        /// Gets or sets the Open interest.
        /// </summary>
        [JsonProperty("open_interest")]
        public long OptionsOpenInterest { get; set; }

        /// <summary>
        /// Gets or sets the Type of option.
        /// </summary>
        [JsonProperty("option_type")]
        public TradierOptionType OptionsOptionType { get; set; }

        /// <summary>
        /// Gets or sets the Strike price.
        /// </summary>
        [JsonProperty("strike")]
        public decimal OptionsStrike { get; set; }

        /// <summary>
        /// Gets or sets the Underlying symbol.
        /// </summary>
        [JsonProperty("underlying")]
        public string OptionsUnderlyingAsset { get; set; }

        /// <summary>
        /// Gets or sets the Daily net change.
        /// </summary>
        [JsonProperty("change_percentage")]
        public decimal PercentageChange { get; set; }

        /// <summary>
        /// Gets or sets the Previous closing price.
        /// </summary>
        [JsonProperty("prevclose")]
        public decimal PreviousClose { get; set; }

        /// <summary>
        /// Gets or sets the Quote Symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the Date and time of last trade.
        /// </summary>
        [JsonProperty("trade_date")]
        public long TradeDateUnix { get; set; }

        /// <summary>
        /// Gets or sets the Type of security.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the Volume for the day.
        /// </summary>
        [JsonProperty("volume")]
        public decimal Volume { get; set; }

        /// <summary>
        /// Gets or sets the 52 week low.
        /// </summary>
        [JsonProperty("week_52_low")]
        public decimal Week52Low { get; set; }
    }
}