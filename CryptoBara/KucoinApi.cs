using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CryptoBara
{
    class KucoinApi : BaseApi
    {
        static List<string> KucoinCoinNames = new List<string>() { "BTC", "ETH" };
        static List<string> KucoinCurrencyNames = new List<string>() { "USDT" };

        public KucoinApi()
        {
            BaseUrl = "https://api.kucoin.com";
            PriceUrl = "/api/v1/market/orderbook/level1?symbol=";

            converter.Init(KucoinCoinNames, KucoinCurrencyNames);
        }

        public class TickerItem
        {
            public long time { get; set; }
            public string sequence { get; set; }
            public string price { get; set; }
            public string size { get; set; }
            public string bestBid { get; set; }
            public string bestBidSize { get; set; }
            public string bestAsk { get; set; }
            public string bestAskSize { get; set; }
        }

        public class Ticker
        {
            public string code { get; set; }
            public TickerItem data { get; set; }
        }

        Ticker ticker = new Ticker();

        public override string GetPrice(string CoinName, string CurrencyName)
        {

            try
            {
                string PriceString = BaseClient.DownloadString(BaseUrl + PriceUrl + converter.CoinNames[CoinName] + "-" + converter.CurrencyNames[CurrencyName]);
                ticker = JsonSerializer.Deserialize<Ticker>(PriceString);
            }
            catch
            {
                ticker.data.bestBid = "REQUEST ERROR";
            }

            return ticker.data.bestBid;
        }
    }
}
