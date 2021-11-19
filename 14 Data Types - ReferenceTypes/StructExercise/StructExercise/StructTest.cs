using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StructExercise
{

    [TestClass]
    public class StructTest
    {
        [TestMethod]
        public void CreateNamedCar_ChangeBrand()
        {
            Car car1 = new Car("Opel");
            Car car2 = car1;

            car2.brand = "VW";

            // TODO: Assert that the brands are equal or not equal. Find out why
            Assert.AreNotEqual(car1.brand, car2.brand);
        }

        [TestMethod]
        public void CreateEmptyCar_ChangeBrand()
        {
            Car car1 = new Car();
            Car car2 = car1;

            car2.brand = "VW";

            // TODO: Assert that the brands are equal or not equal. Find out why
            Assert.AreNotEqual(car1.brand, car2.brand);
        }

        [TestMethod]
        public void CreateNamedBike_ChangeBrand()
        {
            Bike bike1 = new Bike("Gazelle");
            Bike bike2 = bike1;

            bike2.brand = "Giant";

            // TODO: Assert that the brands are equal or not equal. Find out why
            Assert.AreEqual(bike1.brand, bike2.brand);
            Assert.AreSame(bike2, bike1);
        }
    }
}
