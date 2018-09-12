using Fluent.TradierClient.Helper;
using Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale
{
    /// <summary>
    /// Tradier TimeAndSale request.
    /// </summary>
    /// <seealso cref="TradierWebRequest{List{TradierTimeSeries}}" />
    public class TradierTimeSaleRequest
        : TradierWebRequest<List<TradierTimeSeries>>
    {
        /// <summary>
        /// The date format
        /// </summary>
        private const string DateFormat = DateTimeFormats.YearDateHourMinuteFormat;

        /// <summary>
        /// The command
        /// </summary>
        private readonly TradierTimeSaleCommand Command;

        /// <summary>
        /// Initializes a new instance of the <see cref="TradierTimeSaleRequest"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <exception cref="ArgumentNullException">command</exception>
        protected TradierTimeSaleRequest(TradierTimeSaleCommand command)
            : base(command?.BaseUrl, command?.AccessKey)
        {
            Command = command ?? throw new ArgumentNullException(nameof(command));
        }

        /// <summary>
        /// Gets the time sales asynchronous.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        /// <returns>List of Tradier time series.</returns>
        public static async Task<List<TradierTimeSeries>> GetTimeSalesAsync(Func<TradierTimeSaleCommand> commandBuilder)
                => await new TradierTimeSaleRequest(commandBuilder?.Invoke()).GetAsync();

        /// <summary>
        /// Deserializes the JSON token for Tradier result.
        /// </summary>
        /// <param name="jToken">The JSON token.</param>
        /// <returns>The list of time series.</returns>
        protected override List<TradierTimeSeries> Deserialize(JToken jtoken) =>
                SafeListDeserialize<TradierTimeSeries>(jtoken, "series.data");

        /// <summary>
        /// Relative URL to make Tradier request.
        /// </summary>
        /// <returns>Url based on <see cref="Command"/></returns>
        protected override string RelativeUrl()
        {
            // TODO: validate object

            var @params = new Dictionary<string, string>();

            if (Command.StartDate.HasValue && Command.StartDate != DateTime.MinValue)
            {
                @params.Add("start", Command.StartDate.Value.ToString(DateFormat, CultureInfo.InvariantCulture));
                if (Command.EndDate.HasValue)
                {
                    @params.Add("end", Command.EndDate.Value.ToString(DateFormat, CultureInfo.InvariantCulture));
                }
            }

            if (Command.Interval.HasValue)
            {
                @params.Add("interval", Command.Interval.Value.ToMemberValue());
            }

            if (Command.SessionFilter.HasValue)
            {
                @params.Add("session_filter", Command.SessionFilter.Value.ToString().ToLower());
            }

            var req = $"markets/timesales?symbol={Command.Symbol}";

            if (@params.Any())
            {
                req += ("&" + string.Join("&", @params.Select(kvp => string.Format("{0}={1}", kvp.Key, kvp.Value))));
            }

            return req;
        }
    }
}