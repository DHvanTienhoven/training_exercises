using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EqualReferences
{
    [TestClass]
    public class ReferenceEqualityTests
    {
        [TestMethod]
        public void TwoIntegersAreNotReferenceEqual()
        {
            int a = 5;
            int b = a;

            // TODO: Assert that a and b are equal, but not reference equal
        }

        [TestMethod]
        public void TwoStringAreReferenceEqual()
        {
            string a = "Hello";
            string b = a;

            // TODO: Assert that a and b are equal and reference equal
        }

        [TestMethod]
        public void TwoClassesAreReferenceEqual()
        {
            Bike a = new Bike();
            Bike b = a;

            // TODO: Assert that a and b are equal and reference equal
        }

        [TestMethod]
        public void TwoStructsAreNotReferenceEqual()
        {
            Car a = new Car();
            Car b = a;

            // TODO: Assert that a and b are equal, but not reference equal
        }
    }
}
