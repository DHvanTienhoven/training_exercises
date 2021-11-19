using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsListExercise
{
    class Car : Vehicle
    {
        public int NumberOfDoors
        {
            get;
            private set;
        }

        public Car(string brand, int nrOfDoors) : base(brand)
        {
            NumberOfDoors = nrOfDoors;
        }
    }
}
