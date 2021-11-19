using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsListExercise
{
    class Vehicle
    {
        public string Brand
        {
            get;
            private set;
        }

        public Vehicle(string brand)
        {
            Brand = brand;
        }
    }
}
