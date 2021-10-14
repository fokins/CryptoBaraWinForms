using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json;

namespace CryptoBara
{
    class BaseApi
    {
        public WebClient BaseClient = new WebClient();


        public string BaseUrl {  get; set; }
        public string PriceUrl {  get; set; }


        public class Converter
        {
            public List<string> BaseCoinNames = new List<string>() { "BTC", "ETH" };
            public List<string> BaseCurrencyNames = new List<string>() { "USD" };

            public Dictionary<string, string> CoinNames = new Dictionary<string, string>();
            public Dictionary<string, string> CurrencyNames = new Dictionary<string, string>();

            public void Init (List<string> ExchangeCoinNames, List<string> ExchangeCurrencyNames)
            {
                for(int i = 0; i < BaseCoinNames.Count; i++)
                {
                    CoinNames.Add(BaseCoinNames[i], ExchangeCoinNames[i]);
                }

                for(int i = 0; i < ExchangeCurrencyNames.Count; i++)
                {
                    CurrencyNames.Add(BaseCurrencyNames[i], ExchangeCurrencyNames[i]);
                }
            }
        }

        public Converter converter = new Converter();

        public virtual string GetPrice(string CoinName, string CurrencyName) { return "BASE PRICE"; }

        public string GetAllPrices(string CurrencyName)
        {
            string AllPricesString = "";

            foreach (var CoinName in converter.BaseCoinNames)
            {
                AllPricesString += (CoinName + "   " + GetPrice(CoinName, CurrencyName) + "   " + CurrencyName) + Environment.NewLine;
            }

            return AllPricesString;
        }
    }
}
