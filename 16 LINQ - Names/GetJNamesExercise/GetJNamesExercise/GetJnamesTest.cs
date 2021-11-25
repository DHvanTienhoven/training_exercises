using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace GetJNamesExercise
{
    [TestClass]
    public class GetJnamesTest
    {
        [TestMethod]
        public void GetAllNamesThatStartWithJ()
        {
            List<string> names = new List<string>() { "Jack", "John", "Barry", "Peter" };

            List<string> result = names.Where(name => name.StartsWith("J"));

           // foreach(string name in names)
           // {
           //     if (name.StartsWith("J"))
           //     {
           //         result.Add(name);
           //     }
           //    }
            //result.ToArray();
            // TODO: Get all names that start with a J

            CollectionAssert.AreEquivalent(new string[]{ "Jack", "John" }, result);
        }
    }
}
