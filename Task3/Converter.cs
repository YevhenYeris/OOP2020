using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Converter
    {
        Dictionary<string, Dictionary<string, double>> rates = 
            new Dictionary<string, Dictionary<string, double>>();

        public Converter(double usd, double eur)
        {
            rates.Add("uah", new Dictionary<string, double>());
            rates["uah"].Add("uah", 1);
            rates["uah"].Add("usd", 1 / usd);
            rates["uah"].Add("eur", 1 / eur);

            rates.Add("usd", new Dictionary<string, double>());
            rates["usd"].Add("usd", 1);
            rates["usd"].Add("eur", eur / usd);
            rates["usd"].Add("uah", usd);

            rates.Add("eur", new Dictionary<string, double>());
            rates["eur"].Add("eur", 1);
            rates["eur"].Add("usd", usd / eur);
            rates["eur"].Add("uah", eur);
        }

        public double Convert(string from, string to, double val)
        {
            return rates[from][to] * val;
        }
    }

}
