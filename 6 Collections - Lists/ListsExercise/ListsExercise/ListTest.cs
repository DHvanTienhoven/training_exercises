using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListsExercise
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void SimilaritiesOfArrayAndList()
        {
            int[] arrayWithInts = { 5, 6, 80, 5684, 54, 354, 86, 354 };
            List<int> listWithInts = new List<int>{ 5, 6, 80, 5684, 54, 354, 86, 354 };

            // TODO: Get the size of the array and the list, assert them against 8.

            Assert.AreEqual(8, arrayWithInts.Length);
            Assert.AreEqual(8, listWithInts.Count);

            // TODO: Check that the first element of array and list are the same

            Assert.AreEqual(arrayWithInts[0], listWithInts[0]);

            // TODO: Set the 8th element of the array and the list in the same way to 33.

            arrayWithInts[7] = 33;
            listWithInts[7] = 33;

            // TODO: Loop over all items and Assert.AreEqual() them in array and list

            for (int i= 0; i < 8; i++)
                {
                Assert.AreEqual(arrayWithInts[i], listWithInts[i]);
                }
             CollectionAssert.AreEqual(listWithInts, arrayWithInts);

        }

        [TestMethod]
        public void ExtraFunctionsInList()
        {
            List<int> listWithInts = new List<int> { 5, 6, 80, 5684, 54, 354, 86, 354 };
            int[] arrayWithInts = { 5, 6, 80, 5684, 54, 354, 86, 354 };

            // TODO: Add another value to the end of the list

            listWithInts.Add(42);


            Assert.AreEqual(9, listWithInts.Count);

            // TODO: Remove number 80 from the list

            listWithInts.Remove(80);

            Assert.AreEqual(8, listWithInts.Count);

            // TODO: Find the index of number 54

            Assert.AreEqual(3, listWithInts.IndexOf(54));

        }
    }
}
