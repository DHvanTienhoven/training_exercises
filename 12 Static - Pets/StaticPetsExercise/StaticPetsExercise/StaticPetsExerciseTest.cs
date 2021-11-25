using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StaticPetsExercise
{
    [TestClass]
    public class StaticPetsExerciseTest
    {
        [TestMethod]
        public void TwoPets_BothGetAName()
        {
            Pet dog = new Pet();
            dog.SetName("Pluto");
            Pet cat = new Pet();
            cat.SetName("Tom");

            // TODO: Figure out why this test is failing
            Assert.AreEqual("Pluto", dog.GetName());
            Assert.AreEqual("Tom", cat.GetName());
        }

        [TestMethod]
        public void CreatePetShopAndAddPet()
        {
            // TODO: Figure out why this doesn't compile.
            PetShop shop = new PetShop();
            Pet dog = new Pet();
            dog.SetName("Pluto");

            shop.AddPet(dog);
        }

        [TestMethod]
        public void AddPetToTheAsylum()
        {
            // TODO: Figure out why this doesn't compile
            Pet dog = new Pet();
            dog.SetName("Pluto");
            Asylum asylum = new Asylum();
            asylum.AddPet(dog);

            Assert.AreEqual(1, asylum.Count);
        }

        [TestMethod]
        public void CreatingPetsIncreasesTheNumberOfPetsBorn()
        {
            Pet dog = new Pet();
            Pet cat = new Pet();

            // TODO: Figure out why this doesn't compile
            Assert.AreEqual(2, Pet.NumberOfPetsBorn);

            Pet mouse = new Pet();
            Assert.AreEqual(3, Pet.NumberOfPetsBorn);
        }
    }
}
