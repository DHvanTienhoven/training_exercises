using System;

namespace CoffeeMachineExercise
{
    public class CoffeeMachine
    {
        private string _cup;

        public CoffeeMachine(string cup)
        {
            _cup = cup;
        }

        public string MakeChocolateMilk()
        {
            return $"{_cup} of chocolate milk";
        }

        public string MakeCoffee(bool withSugar)
        {
            string result = $"{_cup} of coffee";
            if(withSugar)
            {
                result += AddSugar();
            }
            return result;
            
            // TODO: Make coffee. With sugar?
        }

        protected string AddSugar()
        {
            return " with sugar";
        }
    }
}