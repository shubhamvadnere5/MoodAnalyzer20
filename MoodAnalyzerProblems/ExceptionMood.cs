using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblems
{
   public class ExceptionMood
    {
        public string message;
        public ExceptionMood(string message)
        {
            this.message = message; 
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.ToLower().Contains("happy")) // checking condition if my message contain happy or not
                {
                    return "happy";
                }
                else if (message.ToLower().Contains("sad")) //checking condition if my message contain sad or not
                {
                    return "sad";
                }
                else
                {
                    return "neither happy nor sad";
                }
            }
            catch(NullReferenceException)
            {
                return "happy";
            }
            
        }
    }
}
