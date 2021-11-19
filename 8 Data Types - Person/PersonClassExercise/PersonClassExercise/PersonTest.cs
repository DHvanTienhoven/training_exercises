using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonClassExercise
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void CreatePersonAndGetAge()
        {
            int age = 43;
            Person jack = new Person(age);

            Assert.AreEqual(age, jack.GetAge());
        }

        [TestMethod]
        public void BirthdayPartyIncreasesAge()
        {
            int age = 43;
            Person jack = new Person(age);

            jack.BirthdayParty();

            Assert.AreEqual(age + 1, jack.GetAge());
        }
    }
}
