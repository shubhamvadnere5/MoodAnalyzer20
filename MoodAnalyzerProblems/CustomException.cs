using System;


namespace MoodAnalyzerProblems
{
    public class CustomException : Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            INVALID_MOOD_EXCEPTION,
            EMPTY_TYPE_EXCEPTION,
            CLASS_NOT_FOUND,
            CONSTRUCTOR_NOT_FOUND,
        }

        public CustomException(ExceptionType type, string massage) : base(massage)
        {
            this.type = type;
        }
    }
}