using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Fluent.TradierClient.RequestBuilder.Market.Quotes.Model
{
    /// <summary>
    /// Tradier options expiration
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TradierOptionExpirationType
    {
        /// <summary>
        /// The Option Expiration standard.
        /// </summary>
        [EnumMember(Value = "standard")]
        Standard,

        /// <summary>
        /// The Option Expiration standard.
        /// </summary>
        [EnumMember(Value = "weekly")]
        Weekly
    }
}