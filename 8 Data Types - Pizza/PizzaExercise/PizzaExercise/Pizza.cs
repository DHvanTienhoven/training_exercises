using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaExercise
{
    class Pizza
    {
        private bool baked;
        private List<string> toppings= new List<string>();
        public void Bake()
        {
            baked = true;
        }
        public void AddTopping(string topping)
        {
            toppings.Add(topping);
        }
        public bool IsBaked()
        {
            return baked;
        }
        public bool HasTopping(string topping)
        {
            return toppings.Contains(topping);
        }
    }
}
