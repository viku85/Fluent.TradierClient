using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Interface
{
    public interface IIntervalNextOptionBuilder
        : IStartDateBuilder, IBuild<TradierHistoricalPricingCommand>
    {

    }
}
