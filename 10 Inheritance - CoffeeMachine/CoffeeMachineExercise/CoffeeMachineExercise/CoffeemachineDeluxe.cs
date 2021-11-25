using System;

namespace CoffeeMachineExercise
{
    public class CoffeemachineDeluxe : CoffeeMachine
    {
        public CoffeemachineDeluxe() : base("Glass")
        {
        }

        public string MakeChocoDeluxe()
        {
            return MakeChocolateMilk() + AddSugar() + " and whipped cream";
        }
    }
}