using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json;

namespace CryptoBara
{
    class BinanceApi : BaseApi
    {

        static List<string> BinanceCoinNames = new List<string>() { "BTC", "ETH" };
        static List<string> BinanceCurrencyNames = new List<string>() { "USDT" };

        public BinanceApi()
        {
            BaseUrl = "https://api.binance.com";
            PriceUrl = "/api/v3/ticker/price?symbol=";

            converter.Init(BinanceCoinNames, BinanceCurrencyNames);
        }

        public class Ticker
        {
            public string symbol {  get; set; }
            public string price {  get; set; }
        }

        Ticker ticker = new Ticker();

        public override string GetPrice(string CoinName, string CurrencyName)
        {

            try
            {
                string PriceString = BaseClient.DownloadString(BaseUrl + PriceUrl + converter.CoinNames[CoinName] + converter.CurrencyNames[CurrencyName]);
                ticker = JsonSerializer.Deserialize<Ticker>(PriceString);
            }
            catch
            {
                ticker.price = "REQUEST ERROR";
            }

            return ticker.price;
        }
    }
}
