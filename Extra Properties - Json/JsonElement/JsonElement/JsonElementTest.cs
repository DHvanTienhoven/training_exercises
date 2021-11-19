using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace JsonElementExercise
{
    [TestClass]
    public class JsonElementTest
    {
        [TestMethod]
        public void GetIndexerFromEmptyList_ReturnsNull()
        {
            JsonElement root = new JsonElement();
            Assert.IsNull(root[0]);
        }

        [TestMethod]
        public void GetIndexer_TooHigh_ReturnsNull()
        {
            JsonElement root = new JsonElement();
            root.AddChild(new JsonElement());
            root.AddChild(new JsonElement());

            Assert.IsNull(root[3]);
        }

        [TestMethod]
        public void GetIndexer_Negative_ReturnsNull()
        {
            JsonElement root = new JsonElement();
            root.AddChild(new JsonElement());
            root.AddChild(new JsonElement());

            Assert.IsNull(root[-1]);
        }

        [TestMethod]
        public void GetIndexer_ObjectIsSame()
        {
            JsonElement root = new JsonElement();
            JsonElement el1 = new JsonElement();
            root.AddChild(el1);
            JsonElement el2 = new JsonElement();
            root.AddChild(el2);

            Assert.AreSame(root[0], el1);
            Assert.AreSame(root[1], el2);
        }

        [TestMethod]
        public void SetIndexer_OutOfRange_DoesntThrow()
        {
            JsonElement root = new JsonElement();
            try
            {
                root[54] = new JsonElement();
                Assert.IsNull(root[54]);
                Assert.AreEqual(0, root.Count);
            }
            catch (Exception)
            {
                Assert.Fail("Setter function on out of range threw an exception.");
            }
        }

        
        [TestMethod]
        public void SetIndexer_Negative_DoesntThrow()
        {
            JsonElement root = new JsonElement();
            try
            {
                root[-3] = new JsonElement();
                Assert.IsNull(root[-3]);
                Assert.AreEqual(0, root.Count);
            }
            catch (Exception)
            {
                Assert.Fail("Setter function on out of range threw an exception.");
            }
        }

        [TestMethod]
        public void SetIndexer_ReplacesObject()
        {
            JsonElement root = new JsonElement();
            JsonElement el1 = new JsonElement();
            root.AddChild(el1);

            root[0] = new JsonElement();

            Assert.AreNotSame(root[0], el1);
        }

        [TestMethod]
        public void SetIndexerAndAddChild_SendEvent()
        {
            JsonElement root = new JsonElement();
            int numberOfEvents = 0;
            List<int> expectedIndices = new List<int>{ 0,1,1 };
            root.ChildChanged += (object sender, ChildChangedEventArgs e) => {
                Assert.AreEqual(expectedIndices[numberOfEvents], e.Index);
                numberOfEvents++;
            };
            JsonElement el1 = new JsonElement();
            JsonElement el2 = new JsonElement();

            // sends events
            root.AddChild(el1);
            root.AddChild(el2);

            // sends an event
            root[1] = new JsonElement();

            // doesn't add, so no event
            root[43] = new JsonElement();

            Assert.AreEqual(numberOfEvents, 3);
        }
    }
}
