using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CryptoBara
{
    class KrakenApi : BaseApi    
    {
        public KrakenApi()
        {
            BaseUrl = "https://api.kraken.com";
            PriceUrl = "/0/public/Ticker?pair=";

            List<string> KrakenCoinNames = new List<string>() { "ADA", "XXBT", "XETH", "TRX", "XTZ" };
            List<string> KrakenCurrencyNames = new List<string>() { "ZUSD" };

            converter.Init(KrakenCoinNames, KrakenCurrencyNames);
        }


        public class TickerItem
        {
            public decimal[] a;
            public decimal[] b;
            public decimal[] c;
            public decimal[] v;
            public decimal[] p;
            public decimal[] t;
            public decimal[] l;
            public decimal[] h;
            public decimal o;
        }
        public class Ticker
        {
            public string[] error;
            public Dictionary<string, TickerItem> result;
        }

        public override string GetPrice(string CoinName, string CurrencyName)
        {

            //try
           // {
                string PriceString = BaseClient.DownloadString(BaseUrl + PriceUrl + converter.CoinNames[CoinName] + converter.CurrencyNames[CurrencyName]);
                Ticker ticker = JsonSerializer.Deserialize<Ticker>(PriceString);
            //}
            // catch
            // {
            //      ticker.data.amount = "REQUEST ERROR";
            //}

            string ans = "";

            foreach (var item in ticker.result) ans += item.Key;
            return ans;
            //return PriceString;
        }
    }
}
