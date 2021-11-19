using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DictionaryExercise
{
    /// <summary>
    /// This exercise is about a warehouse 
    /// </summary>
    [TestClass]

    public class DictionaryTests
    {
        [TestMethod]
        public void InitializeDictionary()
        {
            // TODO: Initialize a dictionary of Cheddar = 5, Roquefort = 6, Gouda = 20.
            Dictionary<string, int> cheeseStock = new Dictionary<string, int>();

            cheeseStock["Cheddar"] = 5;
            cheeseStock["Roquefort"] = 6;
            cheeseStock["Gouda"] = 20;

            Assert.AreEqual(3, cheeseStock.Count);

            foreach(KeyValuePair<string, int> entry in cheeseStock)
            {
                Assert.IsTrue(entry.Value > 0);
            }
        }

        [TestMethod]
        public void SomeoneBuysCheddar()
        {
            // TODO: Initialize a dictionary of Cheddar = 5, Roquefort = 6, Gouda = 20.
            Dictionary<string, int> cheeseStock = new Dictionary<string, int>()
            {
                { "Cheddar", 5},
                {"Roquefort", 6 },
                {"Gouda", 20 }
            };

            // TODO: Someone buys a Cheddar. Decrease the stock by 1.

            cheeseStock["Cheddar"] --;

            Assert.AreEqual(4, cheeseStock["Cheddar"]);
        }

        [TestMethod]
        public void LogStocks()
        {
            // TODO: Initialize a dictionary of Cheddar = 5, Roquefort = 6, Gouda = 20.
            Dictionary<string, int> cheeseStock = new Dictionary<string, int>();
            cheeseStock.Add("Cheddar", 5);
            cheeseStock.Add("Roquefort", 6);
            cheeseStock.Add("Gouda", 20);

            // TODO: Put all stocks of all cheeses in a string called log in the format shown below.
            string log = "";

            foreach(var entry in cheeseStock)
            {
                log += $"Stock of {entry.Key} is: {entry.Value}. ";
            }

            Assert.AreEqual("Stock of Cheddar is: 5. Stock of Roquefort is: 6. Stock of Gouda is: 20. ", log);
        }
    }
}
