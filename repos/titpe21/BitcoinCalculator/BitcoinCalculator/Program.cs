using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace BitcoinCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            BitcoinRate currentbitcoin = GetRate();
            Console.WriteLine($"current rate: {currentbitcoin.bpi.EUR.code} {currentbitcoin.bpi.}

            Console.WriteLine("Calculate in: EUR/USD/GBP");
            string userChoice = Console.ReadLine();
            Console.WriteLine("Enter the amount of bitcoins");
            float userCoins = float.Parse(Console.WriteLine());
            float currentRate = 0;

            if(userChoice == "EUR")
            {
                currentRate = currentbitcoin.bpi.EUR.rate_float;
            }

            float result = currentRate * userCoins;
            Console.WriteLine($"your bitcoins are worth {result {userChoise} ");




        }

        public static BitcoinRate GetRate()
        {
            string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRate BitcoinData;

            using(var responseReader = new StreamReader(webStream))
            {
                var reponse = responseReader.ReadToEnd();
                BitcoinData = JsonConvert.DeserializeObject<BitcoinRate>(reponse);
            }

            return BitcoinData;

        }

    }
}
