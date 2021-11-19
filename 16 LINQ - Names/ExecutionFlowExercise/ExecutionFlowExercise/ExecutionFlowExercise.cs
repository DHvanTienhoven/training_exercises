using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExecutionFlowExercise
{
    [TestClass]
    public class ExecutionFlowExercise
    {
        [TestMethod]
        public void QueryAndThenRemoveJohn()
        {
            List<string> names = new List<string>() { "Jack", "John", "Pete", "Barry" };

            IEnumerable<string> result = names.Where(name => name.Length == 4);

            names.Remove("John");

            Assert.AreEqual(/*TODO: true or false*/, result.Contains("John"));
        }

        [TestMethod]
        public void RemoveJohnAndThenQuery()
        {
            List<string> names = new List<string>() { "Jack", "John", "Pete", "Barry" };

            names.Remove("John");

            IEnumerable<string> result = names.Where(name => name.Length == 4);
            
            Assert.AreEqual(/*TODO: true or false*/, result.Contains("John"));
        }

        [TestMethod]
        public void RemoveJohnAndThenQuery_List()
        {
            List<string> names = new List<string>() { "Jack", "John", "Pete", "Barry" };

            names.Remove("John");

            List<string> result = names.Where(name => name.Length == 4).ToList();

            Assert.AreEqual(/*TODO: true or false*/, result.Contains("John"));
        }

        [TestMethod]
        public void QueryAndThenRemoveJohn_List()
        {
            List<string> names = new List<string>() { "Jack", "John", "Pete", "Barry" };

            IEnumerable<string> result = names.Where(name => name.Length == 4).ToList();

            names.Remove("John");

            Assert.AreEqual(/*TODO: true or false*/, result.Contains("John"));
        }
    }
}
