using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Interface
{
    /// <summary>
    /// End date builder for time and sales
    /// </summary>
    public interface IEndDateBuilder
    {
        /// <summary>
        /// Specify End date for timesales.
        /// </summary>
        /// <param name="endDate">The end date.</param>
        /// <returns>Composed TimeSale builder.</returns>
        TradierTimeSaleBuilder WithEndDate(DateTime endDate);
    }
}
