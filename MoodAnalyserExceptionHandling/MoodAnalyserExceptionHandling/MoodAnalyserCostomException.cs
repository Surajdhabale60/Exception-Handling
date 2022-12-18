﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserExceptionHandling
{
    public class MoodAnalyserCostomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD, EMPTY_MOOD, NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        public ExceptionType type;
        public MoodAnalyserCostomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
