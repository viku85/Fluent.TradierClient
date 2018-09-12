using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Fluent.TradierClient.RequestBuilder.Market.Quotes.Model
{
    /// <summary>
    /// Tradier option type
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TradierOptionType
    {
        /// <summary>
        /// The call option type.
        /// </summary>
        [EnumMember(Value = "call")]
        Call,

        /// <summary>
        /// The put option type.
        /// </summary>
        [EnumMember(Value = "put")]
        Put
    }
}