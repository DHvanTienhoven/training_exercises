using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExercise
{
    class Bakery
    {
        public Pizza OrderPepperoniPizza()
        {
            var PepperoniPizza = new Pizza();
            PepperoniPizza.Bake();
            PepperoniPizza.AddTopping("Pepperoni");
            PepperoniPizza.AddTopping("Cheese");
            PepperoniPizza.AddTopping("Tomato sauce");
            return PepperoniPizza;
           
        }
    }
}
