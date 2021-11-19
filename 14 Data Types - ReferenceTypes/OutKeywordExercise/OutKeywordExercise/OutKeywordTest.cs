using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OutKeywordExercise
{
    [TestClass]
    public class OutKeywordTest
    {
        [TestMethod]
        public void HasFileExtension_NoExtension()
        {
            string ext;
            Assert.IsFalse(FileUtils.HasFileExtension("SomeFile", out ext));
            Assert.AreEqual(null, ext);
        }

        [TestMethod]
        public void HasFileExtension_SomeExtension()
        {
            string ext;
            Assert.IsTrue(FileUtils.HasFileExtension("SomeFile.jpeg", out ext));
            Assert.AreEqual("jpeg", ext);
        }

        [TestMethod]
        public void HasFileExtension_EndsWithDot()
        {
            string ext;
            Assert.IsFalse(FileUtils.HasFileExtension("SomeFile.", out ext));
            Assert.AreEqual(null, ext);
        }

        [TestMethod]
        public void HasFileExtension_MultipleDots()
        {
            string ext;
            Assert.IsTrue(FileUtils.HasFileExtension("SomeFile.something.more", out ext));
            Assert.AreEqual("more", ext);
        }
    }
}
