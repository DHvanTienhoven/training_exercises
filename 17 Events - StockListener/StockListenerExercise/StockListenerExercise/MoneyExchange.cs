using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockListenerExercise
{
    class MoneyExchange : IPriceListener
    {
        /// <summary>
        /// The exchange rate is the division between the first and the second Stock.
        /// </summary>
        /// <example>
        /// _first.Price / _second.Price
        /// </example>
        /// <remarks>
        /// Keep this an automatic property
        /// </remarks>
        private double _first;
        private double _second;
        public double ExchangeRate
        {
            get;
            private set;
        }
        public MoneyExchange(Stock stockOne, Stock stockTwo)
        {
            _first = stockOne.Price; 
            _second = stockTwo.Price;
        }

        public void UpdatePrice(double value)
        {
            ExchangeRate = _first/_second;
        }

        // TODO: Construct and listen
    }
}
