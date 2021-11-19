using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressPropertiesExercise
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void MakeAddressWithPublicFields_SetPostalCodeToGarbage_DirectlyChanges()
        {
            AddressWithPublicFields myAddress = new AddressWithPublicFields();

            myAddress.postalCode = "Whatever I want";

            Assert.AreEqual("Whatever I want", myAddress.postalCode);
        }

        [TestMethod]
        public void MakeAddressWithProperties_SetPostalCodeToGarbage_DoesntChange()
        {
            AddressWithProperties myAddress = new AddressWithProperties();

            myAddress.PostalCode = "Whatever I want";

            Assert.AreNotEqual("Whatever I want", myAddress.PostalCode);
        }

        [TestMethod]
        public void MakeAddressWithProperties_SetPostalCodeToFormat_Changes()
        {
            AddressWithProperties myAddress = new AddressWithProperties();

            myAddress.PostalCode = "1234AB";

            Assert.AreEqual("1234AB", myAddress.PostalCode);
        }
    }
}
