using static MoodAnalyserExceptionHandling.MoodAnalyserCostomException;

namespace MoodAnalyserExceptionHandling
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCostomException(ExceptionType.EMPTY_MOOD, "Message should not be Empty");
                }
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCostomException(ExceptionType.NULL_MOOD, "Message should not be null");
            }
        }
    }
}