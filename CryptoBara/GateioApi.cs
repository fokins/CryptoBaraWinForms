using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace CryptoBara
{
    class GateioApi : BaseApi
    {
        static List<string> GateioCoinNames = new List<string>() { "btc", "eth" };
        static List<string> GateioCurrencyNames = new List<string>() { "usdt" };

        public GateioApi()
        {
            BaseUrl = "https://data.gateapi.io";
            PriceUrl = "/api2/1/ticker/";

            converter.Init(GateioCoinNames, GateioCurrencyNames);
        }

        public class Ticker
        {
            public string quoteVolume { get; set; }
            public string baseVolume { get; set; }
            public string highestBid { get; set; }
            public string high24hr { get; set; }
            public string last { get; set; }
            public string lowestAsk { get; set; }
            public string elapsed { get; set; }
            public string result { get; set; }
            public string low24hr { get; set; }
            public string percentChange { get; set; }
        }

        Ticker ticker = new Ticker();

        public override string GetPrice(string CoinName, string CurrencyName)
        {

            try
            {
                string PriceString = BaseClient.DownloadString(BaseUrl + PriceUrl + converter.CoinNames[CoinName] + "_" + converter.CurrencyNames[CurrencyName]);
                ticker = JsonSerializer.Deserialize<Ticker>(PriceString);
            }
            catch
            {
                ticker.highestBid = "REQUEST ERROR";
            }

            return ticker.highestBid;
        }
    }
}
