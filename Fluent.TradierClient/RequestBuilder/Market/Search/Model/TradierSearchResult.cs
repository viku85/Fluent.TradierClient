using Newtonsoft.Json;

namespace Fluent.TradierClient.RequestBuilder.Market.Search.Model
{
    public class TradierSearchResult
    {
        /// <summary>
        /// Gets or sets the company description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the exchange where the company is listed.
        /// </summary>
        [JsonProperty("exchange")]
        public string Exchange { get; set; }

        /// <summary>
        /// Gets or sets the symbol of the company.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or sets the type of the security
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}