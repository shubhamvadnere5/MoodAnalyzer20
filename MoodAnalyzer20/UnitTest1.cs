using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblems;
using System;

namespace MoodAnalyzer20
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenHappyShouldReturnHappy()
        {
            //AAA Methology

            //Arrange
            string excepted = "happy";
            ExceptionMood moodAnalyser = new ExceptionMood("I am in a happy Mood");//Creating a object and passing a message

            //ACT
            string actual = moodAnalyser.AnalyzeMood();

            //ASSERT
            Assert.AreEqual(excepted, actual); ;//Checking my actual result and Excepted Results Matches or not

        }

        [TestMethod]
        public void GivenSadShouldReturnSad()
        {
            //AAA Methology

            //Arrange
            string excepted = "sad";
            ExceptionMood moodAnalyser = new ExceptionMood("I am in a sad mood");//Creating a object and passing a message

            //ACT
            string actual = moodAnalyser.AnalyzeMood();

            //ASSERT
            Assert.AreEqual(excepted, actual);//Checking my actual result and Excepted Results Matches or not

        }

        [TestMethod]
        public void GivenShouldReturnHappy()
        {
            ///AAA methology

            //Arrange
            string expected = "happy";
            ExceptionMood moodanalyzer = new ExceptionMood("I am in happy mood");//created object amd passing message

            //ACT
            string actual = moodanalyzer.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, actual);//checking my actual result and Expected results matches or not
        }
         
    }
}
