using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CryptoBara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetPricesButton_Click(object sender, EventArgs e)
        {
            BinanceApi binanceApi= new BinanceApi();
            KrakenApi krakenApi= new KrakenApi();

            string PricesString = krakenApi.GetPrice("BTC", "USD");

            BinancePriceBox.Text = PricesString;
            

            /*BinancePriceBox.Text = "";

            foreach(var price in PricesString)
            {
                BinancePriceBox.Text += price + Environment.NewLine;
            }*/
        }
    }
}
