using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProblems
{
    public class ModeAnalyzerFactory
    {
        public object CreateMoodAnalyzerObject(string className, string constructor)
        {
            string pattern = "." + constructor + "$";
            Match result = System.Text.RegularExpressions.Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    //Extracting assembly
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    //creating type means class, by taking class name
                    Type moodAnalyzerType = assembly.GetType(className);
                    //Activator-predefined class, used to create object
                    //CreateInstance will create an instance , means it it give reference to object of the given class
                    var res = Activator.CreateInstance(moodAnalyzerType);
                    return res;
                }
                catch (Exception)
                {
                    throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "Class not found");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor not found");
            }
        }
    }
}
