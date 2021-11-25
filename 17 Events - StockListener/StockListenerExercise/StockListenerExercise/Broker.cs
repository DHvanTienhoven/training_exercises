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
        private Stock _stock;


        public Broker(Stock stock)
        {
            _stock = stock;
            stock.PriceChanged += StockPriceChanged;
            UpdatePrice(stock.Price);
        }

        private void StockPriceChanged(object sender, EventArgs e)
        {
            UpdatePrice(_stock.Price);
        }

        public void UpdatePrice(double value)
        {
            if(value > 100)
            {
                IsSelling = true;
            }
            else
            {
                IsSelling = false;
            }

        }
        // TODO: Construct and listen

        // TODO: Selling from everything bigger than 100.
    }
}
