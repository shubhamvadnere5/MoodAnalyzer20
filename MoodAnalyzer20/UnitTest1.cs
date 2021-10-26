using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerProblems;


namespace MoodAnalyzerProblems
{
    [TestClass]
    public class UnitTest1 
    {
        //TC-3 given null will return customized null exception message
        [TestMethod]
        [TestCategory("Customexception")]
        public void GivenNullShouldReturnCustomNullException()
        {
            //AAA Methology

            //Arrange
            string expected = "Message should not be null";
            ExceptionMood exceptionMood = new ExceptionMood(null);
            try
            {
                //ACT
                string actual = exceptionMood.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                //ASSERT
                Assert.AreEqual(expected, ex.Message);
            }
        }

        //TC-3 given empty will return customized empty  message
        [TestMethod]
        [TestCategory("Customexception")]
        public void GivenEmptyShouldReturnCustomEmptyException()
        {
            //AAA Methology

            //Arrange
            string expected = "Message should not be empty";
            ExceptionMood exceptionMood = new ExceptionMood(string.Empty);
            try
            {
                //ACT
                string actual = exceptionMood.AnalyzeMood();
            }
            catch (CustomException ex)
            {
                //ASSERT
                Assert.AreEqual(expected, ex.Message);
            }
        }

        /// TC-4 Create Default Constructor Using Reflection
        /// </summary>
        [TestMethod]
        [TestCategory("Reflection")]
        public void Given_MoodAnalyzer_Using_Reflection_Return_defaultConstructor()
        {
            //Creating object of the class to test
           ExceptionMood exceptionMood = new ExceptionMood();
            object obj = null;
            try
            {
                //ACT
                //
                ModeAnalyzerFactory factory = new ModeAnalyzerFactory();
                obj = factory.CreateMoodAnalyzerObject("MoodanalyzerProblems.ExceptionMood", "ExceptionMood");
            }
            catch (CustomException ex)
            {
                //ASSERT
                throw new Exception(ex.Message);
            }
            obj.Equals(exceptionMood);
        }
        //For negative scenario, if class or constrotor name passed wrong it will give custom exception message
        [TestMethod]
        [TestCategory("Reflection")]
        public void GivenMoodAnalyzerUsingReflectionReturnException()
        {
            string expected = "Constructor not found";
            object obj = null;
            try
            {
                //ACT
                ModeAnalyzerFactory factory = new ModeAnalyzerFactory();
                obj = factory.CreateMoodAnalyzerObject("MoodanalyzerProblems.ExceptionMood", "ExceptionMood");
            }
            catch (CustomException ex)
            {
                //ASSERT
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}