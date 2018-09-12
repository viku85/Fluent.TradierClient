using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.TimeAndSale.Interface
{
    /// <summary>
    /// Default time sale builder.
    /// </summary>
    public interface IDefaultTimeSaleBuilder
    {
        /// <summary>
        /// Specify the symbol.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <returns>Session builder.</returns>
        ISessionBuilder WithSymbol(string symbol);
    }
}
