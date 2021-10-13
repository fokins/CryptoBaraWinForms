using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace CryptoBara
{
    static class Program
    {
        //[STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            */

            Console.WriteLine("PROGRAM RUNNING...");

            BinanceApi binanceApi = new BinanceApi();

            while (true)
            {
                string CoinName = Console.ReadLine();
                string CurrencyName = Console.ReadLine();

                Console.WriteLine(binanceApi.getPrice(CoinName, CurrencyName));

                Thread.Sleep(100);
            }
        }
    }
}