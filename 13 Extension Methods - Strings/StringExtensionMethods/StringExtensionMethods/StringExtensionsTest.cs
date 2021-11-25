using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensionMethods
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void CountWordsExtension_ReturnsFour()
        {
            string input = "My name is John!";


            int TODO = StringExtensions.CountWords(input);

            // TODO: Call the CountWords() function as an extension method
            Assert.AreEqual(4, TODO);
        }

        [TestMethod]
        public void CountWordsMethod_ReturnsFour()
        {
            string input = "My name is John!";

            int TODO = input.CountWords();

            // TODO: Try to call the CountWords() function as a simple static method. Why does this work or not?
            Assert.AreEqual(4, TODO);
        }

        [TestMethod]
        public void CountSpacesMethods_ReturnsThree()
        {
            string input = "My name is John!";

            int TODO = input.CountWhitespace();
    
            // TODO: Call the CountWhitespace() function as a simple static method
            // Could you also call it as an extension method? What do you need to change for that?
            Assert.AreEqual(3, TODO);
        }
    }
}
