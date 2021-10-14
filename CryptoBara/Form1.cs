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
        BinanceApi binanceApi = new BinanceApi();
        KrakenApi krakenApi = new KrakenApi();
        KucoinApi coinbaseApi = new KucoinApi();
        GateioApi gateioApi = new GateioApi();

        public Form1()
        {
            InitializeComponent();
        }

        private void PricesUpdate()
        {
            string BinancePricesString = binanceApi.GetAllPrices("USD");
            string KrakenPricesString = krakenApi.GetAllPrices("USD");
            string KucoinPricesString = coinbaseApi.GetAllPrices("USD");
            string GateioPricesString = gateioApi.GetAllPrices("USD");

            BinancePriceBox.Text = BinancePricesString;
            KrakenPriceBox.Text = KrakenPricesString; 
            KucoinPriceBox.Text = KucoinPricesString;
            GateioPriceBox.Text = GateioPricesString;
        }

        private void GetPricesButton_Click(object sender, EventArgs e)
        {
            PricesUpdate();
        }
    }
}
