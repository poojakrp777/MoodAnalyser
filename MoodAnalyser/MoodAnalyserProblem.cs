using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser.MoodAnalyserCustomException;

namespace MoodAnalyser
{
    public class MoodAnalyserProblem
    {
        public string AnalyseMood(string moodMessage)
        {
            try
            {
                if (moodMessage == null)
                {
                    throw new MoodAnalyserCustomException(ExceptionType.NULL_MESSAGE_EXCEPTION, "Null message passed.");
                }
                if (moodMessage.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(ExceptionType.EMPTY_MESSAGE_EXCEPTION, "Empty message passed.");
                }
                if (moodMessage.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
