using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblems
{
    class CustomException:Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            EMPTY_TYPE_EXCEPTION,
            INVALID_MOOD_EXCEPTION,
        }
        public CustomException(ExceptionType type, string message): base(message)
        {
            this.type = type;
        }
    }
}
