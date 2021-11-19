using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockListenerExercise
{
    class Broker : IPriceListener
    {
        /// <summary>
        /// Selling when the price of the Stock is bigger than 100.
        /// </summary>
        /// <remarks>
        /// Keep this an automatic property
        /// </remarks>
        public bool IsSelling
        {
            get;
            private set;
        }

        // TODO: Construct and listen

        // TODO: Selling from everything bigger than 100.
    }
}
