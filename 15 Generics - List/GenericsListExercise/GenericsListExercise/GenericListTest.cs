using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace GenericsListExercise
{
    [TestClass]
    public class GenericListTest
    {
        [TestMethod]
        public void AllBikesInListHaveHandbrakes_VehicleList()
        {
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Bike("Giant", true),
                new Bike("Gazelle", true),
                new Bike("Sparta", true),
                new Car("VW", 5)
            };

            List<Bike> bikes = vehicles.OfType<Bike>().ToList();
            List<Bike> bikesWithHandbrakes = vehicles.OfType<Bike>().Where(bike => bike.HasHandBrakes).ToList();

            Assert.AreEqual(bikes.Count, bikesWithHandbrakes.Count);

            // TODO: Loop over all bikes and Assert that they all have hand brakes
        }

        [TestMethod]
        public void AllBikesInListHaveHandbrakes_BikeList()
        {
            List<Bike> bikes = new List<Bike>
            {
                new Bike("Giant", true),
                new Bike("Gazelle", true),
                new Bike("Sparta", true)
            };

            List<Bike> bikesWithHandbrakes = bikes.Where(bike => bike.HasHandBrakes).ToList();
            Assert.AreEqual(bikes.Count, bikesWithHandbrakes.Count);
            // TODO: Loop over all bikes and Assert that they all have hand brakes
        }

        [TestMethod]
        public void AddOtherVehiclesToBikeList()
        {
            List<Bike> bikes = new List<Bike>();
          //  bikes.Add(new Car());
            // TODO: Try to add a Car to the list of Bikes.
        }

        [TestMethod]
        public void MyTestMethod()
        {
            // An arraylist is a List with objects of type: Object.
            // You can put in whatever you want.
            // It is very similar to List<object>.
            ArrayList vehicles = new ArrayList()
            {
                new Bike("Peugeot", true),
                new Bike("Peugeot", false),
                new Car("Peugeot", 3),
                new Car("Peugeot", 5)
            };


            // TODO: Loop over all vehicles and assert that they are all Peugeots.

            vehicles.Add("Mike");
            vehicles.Add("Danny");

            // TODO: Loop over all vehicles again and assert that they are all Peugeots.
        }
    }
}
