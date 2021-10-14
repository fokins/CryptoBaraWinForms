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
        static List<string> KrakenCoinNames = new List<string>() { "XXBT", "XETH" };
        static List<string> KrakenCurrencyNames = new List<string>() { "ZUSD" };

        public KrakenApi()
        {
            BaseUrl = "https://api.kraken.com";
            PriceUrl = "/0/public/Ticker?pair=";

            converter.Init(KrakenCoinNames, KrakenCurrencyNames);
        }


        public class TickerItem
        {
            public string[] a { get; set; }
            public string[] b { get; set; }
            public string[] c { get; set; }
            public string[] v { get; set; }
            public string[] p { get; set; }
            public decimal[] t { get; set; }
            public string[] l { get; set; }
            public string[] h { get; set; }
            public string o { get; set; }
        }
        public class Ticker
        {
            public string[] error { get; set; }
            public Dictionary<string, TickerItem> result { get; set; }
        }

        public override string GetPrice(string CoinName, string CurrencyName)
        {

            Ticker ticker = new Ticker();

            try
            {
                string PriceString = BaseClient.DownloadString(BaseUrl + PriceUrl + converter.CoinNames[CoinName] + converter.CurrencyNames[CurrencyName]);
                ticker = JsonSerializer.Deserialize<Ticker>(PriceString);
            }
            catch
            {
                return "REQUEST ERROR";
            }
            return ticker.result[converter.CoinNames[CoinName] + converter.CurrencyNames[CurrencyName]].b[0];
        }
    }
}
