using Newtonsoft.Json;

namespace Fluent.TradierClient.RequestBuilder.Market.Search.Model
{
    public class TradierSearchResult
    {
        /// <summary>
        /// The company description
        /// </summary>
        [JsonProperty("description")]
        public string Description;

        /// <summary>
        /// The exchange where the company is listed.
        /// </summary>
        [JsonProperty("exchange")]
        public string Exchange;

        /// <summary>
        /// The symbol of the company.
        /// </summary>
        [JsonProperty("symbol")]
        public string Symbol;

        /// <summary>
        /// The type of the security
        /// </summary>
        [JsonProperty("type")]
        public string Type;
    }
}