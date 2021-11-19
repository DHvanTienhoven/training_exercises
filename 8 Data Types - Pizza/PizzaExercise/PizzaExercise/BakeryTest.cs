using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PizzaExercise
{

    [TestClass]
    public class BakeryTest
    {
        [TestMethod]
        public void BakePepperoniPizza_HasCorrectToppings()
        {
            Bakery bakery = new Bakery();
            Pizza pizza = bakery.OrderPepperoniPizza();

            Assert.IsTrue(pizza.HasTopping("Cheese"));
            Assert.IsTrue(pizza.HasTopping("Tomato sauce"));
            Assert.IsTrue(pizza.HasTopping("Pepperoni"));
            Assert.IsTrue(pizza.IsBaked());
        }
    }
}
