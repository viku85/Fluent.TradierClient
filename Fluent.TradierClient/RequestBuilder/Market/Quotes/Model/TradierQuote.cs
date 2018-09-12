using Newtonsoft.Json;

namespace Fluent.TradierClient.RequestBuilder.Market.Quotes.Model
{
    /// <summary>
    /// Tradier quote model.
    /// </summary>
    public class TradierQuote
    {
        /// <summary>
        /// The Opening price.
        /// </summary>
        [JsonProperty("open")]
        public decimal? Open = 0;

        /// <summary>
        /// The 52 week high.
        /// </summary>
        [JsonProperty("week_52_high")]
        public decimal Week52High = 0;

        /// <summary>
        /// The Current ask.
        /// </summary>
        [JsonProperty("ask")]
        public decimal Ask { get; set; }

        /// <summary>
        /// The Date and time of current ask.
        /// </summary>
        [JsonProperty("ask_date")]
        public long AskDateUnix { get; set; }

        /// <summary>
        /// The Exchange of ask.
        /// </summary>
        [JsonProperty("askexch")]
        public string AskExchange { get; set; }

        /// <summary>
        /// The Size of ask.
        /// </summary>
        [JsonProperty("asksize")]
        public decimal AskSize { get; set; }

        /// <summary>
        /// The Average daily volume.
        /// </summary>
        [JsonProperty("average_volume")]
        public decimal AverageVolume { get; set; }

        /// <summary>
        /// The Current bid.
        /// </summary>
        [JsonProperty("bid")]
        public decimal Bid { get; set; }

        /// <summary>
        /// The Date and time of current bid.
        /// </summary>
        [JsonProperty("bid_date")]
        public long BidDateUnix { get; set; }

        /// <summary>
        /// The Size of bid.
        /// </summary>
        [JsonProperty("bidsize")]
        public decimal BidSize { get; set; }

        /// <summary>
        /// The Exchange of bid.
        /// </summary>
        [JsonProperty("bidexch")]
        public string BigExchange { get; set; }

        /// <summary>
        /// The Daily net change.
        /// </summary>
        [JsonProperty("change")]
        public decimal Change { get; set; }

        /// <summary>
        /// The Closing price.
        /// </summary>
        [JsonProperty("close")]
        public decimal? Close { get; set; }

        /// <summary>
        /// The Symbol description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The Quote Exchange.
        /// </summary>
        [JsonProperty("exch")]
        public string Exchange { get; set; }

        /// <summary>
        /// The Trading day high.
        /// </summary>
        [JsonProperty("high")]
        public decimal? High { get; set; }

        /// Quote Last Price
        [JsonProperty("last")]
        public decimal Last { get; set; }

        /// <summary>
        /// The Last incremental volume.
        /// </summary>
        [JsonProperty("last_volume")]
        public decimal LastVolume { get; set; }

        /// <summary>
        /// TheTrading day low
        /// </summary>
        [JsonProperty("low")]
        public decimal? Low { get; set; }

        /// <summary>
        /// The Size of the contract in shares.
        /// </summary>
        [JsonProperty("contract_size")]
        public int OptionsContractSize { get; set; }

        /// <summary>
        /// The Date of expiration.
        /// </summary>
        [JsonProperty("expiration_date")]
        public long OptionsExpirationDate { get; set; }

        /// <summary>
        /// The Type of expiration.
        /// </summary>
        [JsonProperty("expiration_type")]
        public TradierOptionExpirationType OptionsExpirationType { get; set; }

        /// <summary>
        /// The Open interest.
        /// </summary>
        [JsonProperty("open_interest")]
        public long OptionsOpenInterest { get; set; }

        /// <summary>
        /// The Type of option.
        /// </summary>
        [JsonProperty("option_type")]
        public TradierOptionType OptionsOptionType { get; set; }

        /// <summary>
        /// The Strike price.
        /// </summary>
        [JsonProperty("strike")]
        public decimal OptionsStrike { get; set; }

        /// <summary>
        /// The Underlying symbol.
        /// </summary>
        [JsonProperty("underlying")]
        public string OptionsUnderlyingAsset { get; set; }

        /// <summary>
        /// The Daily net change.
        /// </summary>
        [JsonProperty("change_percentage")]
        public decimal PercentageChange { get; set; }

        /// <summary>
        /// The Previous closing price.
        /// </summary>
        [JsonProperty("prevclose")]
        public decimal PreviousClose { get; set; }

        /// <summary>
        /// The Quote Symbol.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// The Date and time of last trade.
        /// </summary>
        [JsonProperty("trade_date")]
        public long TradeDateUnix { get; set; }

        /// <summary>
        /// The Type of security.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The Volume for the day.
        /// </summary>
        [JsonProperty("volume")]
        public decimal Volume { get; set; }

        /// <summary>
        /// The 52 week low.
        /// </summary>
        [JsonProperty("week_52_low")]
        public decimal Week52Low { get; set; }
    }
}