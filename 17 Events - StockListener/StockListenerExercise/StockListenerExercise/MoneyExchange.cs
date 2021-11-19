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
        public double ExchangeRate
        {
            get;
            private set;
        }

        // TODO: Construct and listen
    }
}
