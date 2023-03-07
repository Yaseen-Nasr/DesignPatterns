using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class CurrencyConverter
    {
        private IEnumerable<ExchangeRate> _exchangeRates;
        private CurrencyConverter()
        {
            LoadExchangeRates();
        }
        private static object _lock = new();
        //Lazy initialization 
        private static CurrencyConverter _instance;
        public static CurrencyConverter Instance
        {
            get
            {
                //Double check
                if (_instance is null) 
                {
                    lock (_lock)
                    {
                        if (_instance is null)
                            _instance = new CurrencyConverter();
                    }
                }
                return _instance;
            }
        }

        private void LoadExchangeRates()
        {
            Thread.Sleep(3000);
            _exchangeRates = new[]
            {
                new ExchangeRate("USD","SAR",3.75m),
                new ExchangeRate("USD","EGP",30.60m),
                new ExchangeRate("SAR","EGP",8.16m),
            };
        }
        public decimal Convert(string baseCurrency, string targetCurrency, decimal amount)
        {
            //Assum Happy bath without null checks
            var exchangeRate = _exchangeRates.FirstOrDefault(rate => rate.BaseCurrency == baseCurrency && rate.TargetCurrency == targetCurrency);
            return amount * exchangeRate!.Rate;
        }
    }
}
