using MoodAnalyzerProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
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
                if (message.ToLower().Equals(string.Empty))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_TYPE_EXCEPTION, "Message should not be empty");
                }
                else if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MOOD_EXCEPTION, "Message should not be null");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}