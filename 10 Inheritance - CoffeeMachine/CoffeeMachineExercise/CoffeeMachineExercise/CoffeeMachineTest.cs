using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMachineExercise
{
    [TestClass]
    public class CoffeeMachineTest
    {
        [TestMethod]
        public void MakeChocolateMilk()
        {
            CoffeeMachine machine = new CoffeeMachine("Paper cup");
            string milk = machine.MakeChocolateMilk();

            Assert.AreEqual("Paper cup of chocolate milk", milk);
        }

        [TestMethod]
        public void MakeCoffeeWithSugar()
        {
            CoffeeMachine machine = new CoffeeMachine("Paper cup");
            string coffee = machine.MakeCoffee(true);

            Assert.AreEqual("Paper cup of coffee with sugar", coffee);
        }

        [TestMethod]
        public void MakeCoffeeWithoutSugar()
        {
            CoffeeMachine machine = new CoffeeMachine("Paper cup");
            string coffee = machine.MakeCoffee(false);

            Assert.AreEqual("Paper cup of coffee", coffee);
        }

        [TestMethod]
        public void MakeChocoDeluxe()
        {
            CoffeemachineDeluxe machine = new CoffeemachineDeluxe();

            string milk = machine.MakeChocoDeluxe();

            Assert.AreEqual("Glass of chocolate milk with sugar and whipped cream", milk);
        }
    }
}
