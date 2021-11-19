using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockListenerExercise
{
    public class Stock
    {
        private double _price;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;

                // TODO: Notify the listeners
            }
        }

        public Stock(double price)
        {
            _price = price;
        }

        public void AddListener(IPriceListener listener)
        {
            // TODO: Add listener to the listeners list
        }
    }
}
