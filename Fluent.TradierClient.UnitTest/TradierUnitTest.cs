using Fluent.TradierClient.RequestBuilder;
using Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings;
using Fluent.TradierClient.RequestBuilder.Market.HistoricalPricings.Model;
using Fluent.TradierClient.RequestBuilder.Market.InterDayStatues;
using Fluent.TradierClient.RequestBuilder.Market.MarketCalenders;
using Fluent.TradierClient.RequestBuilder.Market.MarketCalenders.Commands;
using Fluent.TradierClient.RequestBuilder.Market.OptionChains;
using Fluent.TradierClient.RequestBuilder.Market.OptionExpirations;
using Fluent.TradierClient.RequestBuilder.Market.OptionStrikes;
using Fluent.TradierClient.RequestBuilder.Market.Quotes;
using Fluent.TradierClient.RequestBuilder.Market.Search;
using Fluent.TradierClient.RequestBuilder.Market.StreamSession;
using Fluent.TradierClient.RequestBuilder.Market.SymbolLookup;
using Fluent.TradierClient.RequestBuilder.Market.TimeAndSale;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fluent.TradierClient.UnitTest
{
    [TestClass]
    public class TradierUnitTest
    {
        private const string AccessKey = "<provide access key>";
        private const AccountType AccType = AccountType.Sandbox;

        #region " Helper methods "

        private void WriteOutput<T>(T value)
    where T : class
        {
            if (value != null)
            {
                Console.WriteLine(JsonConvert.SerializeObject(value));
            }
        }

        private void WriteOutput<T>(List<T> list)
        {
            if (list != null)
            {
                Console.WriteLine($"Data Count: {list.Count}");
                Console.WriteLine(JsonConvert.SerializeObject(list));
            }
        }

        #endregion " Helper methods "

        #region " Historical pricing "

        [TestMethod]
        public async Task HistoricalPricingSymbolAsync()
        {
            var res = await TradierHistoricalPricingRequest.GetHistoryDataAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForHistoricalData("SPY")
                .Build
                );

            WriteOutput(res);
            Assert.IsTrue(res.Any());
        }

        [TestMethod]
        public async Task HistoricalPricingSymbolIntervalAsync()
        {
            var res = await TradierHistoricalPricingRequest.GetHistoryDataAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForHistoricalData("SPY")
                .WithInterval(HistoryIntervalOption.Monthly)
                .Build
                );

            WriteOutput(res);

            Assert.IsTrue(res.Any());
        }

        [TestMethod]
        public async Task HistoricalPricingSymbolIntervalDateRangeAsync()
        {
            var res = await TradierHistoricalPricingRequest.GetHistoryDataAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForHistoricalData("SPY")
                .WithInterval(HistoryIntervalOption.Monthly)
                .WithStartDate(DateTime.Now.AddMonths(-1))
                .WithEndDate(DateTime.Now)
                .Build
                );

            WriteOutput(res);

            Assert.IsTrue(res.Any());
        }

        #endregion " Historical pricing "

        #region " Inter day status "

        [TestMethod]
        public async Task InterDayCommandAsync()
        {
            var res = await TradierInterDayStatusRequest.GetMarketStatusAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForInterDayStatus()
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        #endregion " Inter day status "

        #region " Market Calendars "

        [TestMethod]
        public async Task MarketAsync()
        {
            var res = await TradierMarketCalenderRequest.GetMarketCalendarAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForMarketCalendar()
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task MarketMonthAsync()
        {
            var res = await TradierMarketCalenderRequest.GetMarketCalendarAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForMarketCalendar()
                .WithMonth(Month.October)
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task MarketYearAsync()
        {
            var res = await TradierMarketCalenderRequest.GetMarketCalendarAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForMarketCalendar()
                .WithYear(2018)
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task MarketYearMonthAsync()
        {
            var res = await TradierMarketCalenderRequest.GetMarketCalendarAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForMarketCalendar()
                .WithYear(2018)
                .WithMonth(Month.October)
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        #endregion " Market Calendars "

        #region " Option Chain Expirations "

        [TestMethod]
        public async Task OptionChainExpirationAsync()
        {
            var res = await TradierOptionExpirationRequest.GetOptionExpiryAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForOptionExpiry("SPY")
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        #endregion " Option Chain Expirations "

        #region " Option Chains "

        [TestMethod]
        public async Task OptionChainAsync()
        {
            var res = await TradierOptionChainRequest.GetOptionChainAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForOptionChain("SPY")
                .WithExpirationDate(DateTime.Now.AddDays(-2))
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task OptionChainAutoExpiryAsync()
        {
            var res = await TradierOptionChainRequest.GetOptionChainAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForOptionChain("SPY")
                .AutoExpiryLimit(2)
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        #endregion " Option Chains "

        #region " Option Strikes "

        [TestMethod]
        public async Task OptionStrikesAsync()
        {
            var res = await TradierOptionStrikeRequest.GetOptionStrikesAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForOptionStrike("SPY")
                .WithAutoExpiryLimit(4)
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task OptionStrikesDateAsync()
        {
            var res = await TradierOptionStrikeRequest.GetOptionStrikesAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForOptionStrike("SPY")
                .WithExpiry(DateTime.Now.AddDays(-2))
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        #endregion " Option Strikes "

        #region " Quotes "

        [TestMethod]
        public async Task MultipleQuotesAsync()
        {
            var res = await TradierQuoteRequest.GetQuoteAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForQuotes("SPY", "AAPL")
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task QuotesAsync()
        {
            var res = await TradierQuoteRequest.GetQuoteAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForQuotes("SPY")
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        #endregion " Quotes "

        #region " Search "

        [TestMethod]
        public async Task SearchAsync()
        {
            var res = await TradierSearchRequest.GetSearchResultAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .WithSearchQuery("aap")
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        #endregion " Search "

        #region " Stream Session "

        [TestMethod]
        public async Task NewSessionAsync()
        {
            // NOTE: Works only with Live account.
            var res = await TradierStreamSessionRequest.CreateSessionAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .CreateSession()
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        #endregion " Stream Session "

        #region " Symbol look up "

        [TestMethod]
        public async Task SymbolAsync()
        {
            var res = await TradierSymbolLookupRequest.GetLookupResultAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForSymbolLookup()
                .WithSymbolQuery("SP")
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task SymbolExchangeAsync()
        {
            var res = await TradierSymbolLookupRequest.GetLookupResultAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForSymbolLookup()
                .WithSymbolQuery("SP")
                .WithTypeFilter("etf")
                .WithExchangeFilter("Z")
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task SymbolTypeAsync()
        {
            var res = await TradierSymbolLookupRequest.GetLookupResultAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForSymbolLookup()
                .WithSymbolQuery("SP")
                .WithTypeFilter("etf")
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        #endregion " Symbol look up "

        #region " Time and Sales "

        [TestMethod]
        public async Task TimeSaleAsync()
        {
            var res = await TradierTimeSaleRequest.GetTimeSalesAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForTimeSale()
                .WithSymbol("SPY")
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        [TestMethod]
        public async Task TimeSaleSessionAsync()
        {
            var res = await TradierTimeSaleRequest.GetTimeSalesAsync(
                TradierBuilder.WithAccount(AccType, AccessKey)
                .ForMarket()
                .ForTimeSale()
                .WithSymbol("SPY")
                .WithSession(SessionFilter.Open)
                .Build
                );

            WriteOutput(res);
            Assert.IsNotNull(res);
        }

        #endregion " Time and Sales "
    }
}