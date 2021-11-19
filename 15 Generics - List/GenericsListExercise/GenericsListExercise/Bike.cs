using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsListExercise
{
    class Bike : Vehicle
    {
        public bool HasHandBrakes
        {
            get;
            private set;
        }

        public Bike(string brand, bool hasHandBrakes) : base(brand)
        {
            HasHandBrakes = hasHandBrakes;
        }
    }
}
