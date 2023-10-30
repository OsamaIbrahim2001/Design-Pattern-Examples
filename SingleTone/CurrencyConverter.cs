using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
    public class CurrencyConverter
    {
        private IEnumerable<ExchangeRate> _exchangeRates;
        private CurrencyConverter()
        {
            LoadExchangeRates(); 
        }
        private static object _lock = new ();
        private static CurrencyConverter _instance;
        public static CurrencyConverter Instance
        {
            get
            {
                lock (_lock)
                {
                    if(_instance==null)
                        _instance = new CurrencyConverter();
                }
                return _instance;
            }
        }
        private void LoadExchangeRates()
        {
            Thread.Sleep(3000);
            _exchangeRates = new[] {
            new ExchangeRate("USD","SAR",3.75m),
            new ExchangeRate("USD","EGP",30.60m),
            new ExchangeRate("SAR","EGP",8.16m)
            };
        }

        public decimal Covert(string baseCurrency,string targetCurrency,decimal amount)
        {
            var exchangeRate = _exchangeRates.First(e=>e.BaseCurrency==baseCurrency&&e.TargetCurrency==targetCurrency);
            return amount * exchangeRate.Rate;
        }
    }
}
