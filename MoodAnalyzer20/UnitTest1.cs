using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
using System;
using System.Runtime.Serialization;

namespace MoodTesting
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
            Assert.AreEqual(excepted, actual); ;//Checking wether my actual rasult and Excepted Results Matches or not

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
            Assert.AreEqual(excepted, actual);//Checking wether my actual rasult and Excepted Results Matches or not

        }
        [TestMethod]
        [TestCategory("Customexception")]
        public void GivenNullShouldReturnCustomNullException()
        {
            //AAA Methology

            //Arrange
            string excepted = "Message should not be null";
            ExceptionMood moodAnalyser = new ExceptionMood(null);//Passing an Null Message To call Null_Type_Exception
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyzeMood();
            }

            catch (CustomException ex)
            {
                //ASSERT
                Assert.AreEqual(excepted, ex.Message);//Checking wether my actual result and Excepted Results Matches or not
            }
        }

        [TestMethod]
        [TestCategory("Customexception")]
        public void GivenEmptyShouldReturnCustomEmptyException()
        {
            //AAA Methology

            //Arrange
            string excepted = "Message should not be empty";
            ExceptionMood moodAnalyser = new ExceptionMood(string.Empty);//Passing an Empty Message  To call Empty_Type_Exception
            try
            {
                //ACT
                string actual = moodAnalyser.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                //ASSERT
                Assert.AreEqual(excepted, ex.Message);//Checking wether my actual result and Excepted Results Matches or not
            }
        }

    }

}