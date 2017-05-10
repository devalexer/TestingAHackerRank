using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingAHackerRank;

namespace PangramTesting
{
    [TestClass]
    public class Pangram
    {
        [TestMethod]
        public void LongSentence()
        {
            //Arrange
            var testString = "We promptly judged antique ivory buckles for the next prize";
            //Act
            var answer = Solution.PangramSolution(testString);
            //Assert
            Assert.AreEqual("pangram", answer);
        }

        [TestMethod]
        public void ShorterSentence()
        {
            //Arrange
            var testString = "We promptly judged antique ivory buckles for the prize";
            //Act
            var answer = Solution.PangramSolution(testString);
            //Assert
            Assert.AreEqual("not pangram", answer);
        }

        [TestMethod]
        public void EmptySentence()
        {
            //Arrange
            var testString = " ";
            //Act
            var answer = Solution.PangramSolution(testString);
            //Assert
            Assert.AreEqual("not pangram", answer);
        }

        [TestMethod]
        public void NumberSentence()
        {
            //Arrange
            var testString = "12 little birds sitting in a pie";
            //Act
            var answer = Solution.PangramSolution(testString);
            //Assert
            Assert.AreEqual("not pangram", answer);
        }

        [TestMethod]
        public void AlphabetSentence()
        {
            //Arrange
            var testString = "qwertyuioplkjhgfdsazxcvbnmqwertyuioplkjhgfdsazxcvbnm";
            //Act
            var answer = Solution.PangramSolution(testString);
            //Assert
            Assert.AreEqual("pangram", answer);
        }
    }
}
