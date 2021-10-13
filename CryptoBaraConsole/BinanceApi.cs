using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CryptoBara
{
    class BinanceApi
    {
        const string BaseUrl = "https://api.binance.com";
        const string GetPriceUrl = "/api/v3/ticker/price?symbol=";

        List<string> CoinNames = new List<string>(){ "XTZ", "VET", "ADA", "TRX", "BTC"};
        List<string> CurrencyNames = new List<string>() { "USDT", "RUB" };

        WebClient BinanceClient = new WebClient();

        public string getPrice(string CoinName, string CurrencyName)
        {
            Console.WriteLine("Checking the correctness of the request");

            if (!CoinNames.Contains(CoinName))
            {
                Console.WriteLine("Invalid coin name");
                return "Invalid coin name";
            }

            if (!CurrencyNames.Contains(CurrencyName))
            {
                Console.WriteLine("Invalid currency name");
                return "Invalid currency name";
            }

            try
            {
                return BinanceClient.DownloadString(BaseUrl + GetPriceUrl + CoinName + CurrencyName);
            }
            catch
            {
                Console.WriteLine("REQUEST ERROR");
                return "REQUEST ERROR";
            }
        }
    }
}
