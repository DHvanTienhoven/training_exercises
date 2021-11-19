using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetJNamesExercise
{
    [TestClass]
    public class GetJnamesTest
    {
        [TestMethod]
        public void GetAllNamesThatStartWithJ()
        {
            List<string> names = new List<string>() { "Jack", "John", "Barry", "Peter" };

            List<string> result = new List<string>();

            // TODO: Get all names that start with a J

            CollectionAssert.AreEquivalent(new string[]{ "Jack", "John" }, result);
        }
    }
}
