using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace konverter1
{
    public partial class CurrencyForm : Form
    {
        public CurrencyForm()
        {
            InitializeComponent();
            Nbrb();
            fromCurrency.SelectedIndex = 0;
            toCurrency.SelectedIndex = 1;
            fromAmount.Text = "";
            convertButton.Enabled = false;
        }

        private Dictionary<string, double> Currencies { get; set; }

        private void WaitingConnection()
        {
            while (!NetworkInterface.GetIsNetworkAvailable())
            {
            }
            Currencies = new Dictionary<string, double>
            {
                {"USD", GetCurrRate(145)},
                {"EUR", GetCurrRate(292)},
                {"RUB", GetCurrRate(298)},
                {"BYN", 1}
            };
            fromAmount.Invoke((Action) TextBoxReady);
        }

        private void TextBoxReady()
        {
            fromAmount.ReadOnly = false;
            messageBox.Text = $"EUR: {Currencies["EUR"]}\r\nUSD: {Currencies["USD"]}\r\nRUB: {Currencies["RUB"]}\n";
        }

        private void Nbrb()
        {
            messageBox.Text = @"Подключение к интернету...";
            fromAmount.ReadOnly = true;
            var waitingConnection = new Thread(WaitingConnection);
            waitingConnection.Start();
        }

        private double GetCurrRate(int id)
        {
            var response = DownloadPage($"http://www.nbrb.by/API/ExRates/Rates/{id}");
            var o = JObject.Parse(response);
            return (double) o.SelectToken("Cur_OfficialRate") / (double) o.SelectToken("Cur_Scale");
        }

        private static string DownloadPage(string url)
        {
            string str;
            using (var wc = new WebClient())
            {
                str = wc.DownloadString(url);
            }
            return str;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            var sum = Convert.ToDouble(fromAmount.Text);
            var converter = new Converter();
            var r = converter.Convert(sum, Currencies[fromCurrency.SelectedItem.ToString()],
                Currencies[toCurrency.SelectedItem.ToString()]);
            double h;
            h = Math.Round(r, 2);
            toAmount.Text = h.ToString(CultureInfo.InvariantCulture);
        }

        private void FromAmont_KeyUp(object sender, KeyEventArgs e)
        {
            fromAmount.Text = Regex.Match(fromAmount.Text, @"([0-9]+([,][0-9]*)?|[,][0-9]+)").Value;
            fromAmount.SelectionStart = fromAmount.Text.Length;
            convertButton.Enabled = fromAmount.Text.Length != 0;
        }
    }
}