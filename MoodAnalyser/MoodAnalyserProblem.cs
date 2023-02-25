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
        //variable
        public string message;

        // default contructor

        public MoodAnalyserProblem()
        {

        }

        public class MoodAnalyzerProblems
        {
            //parameterized constructor
            public string AnalyseMood(string moodMessage)
            {

                try
                {
                    if (moodMessage == null)
                    {
                        throw new MoodAnalyserCustomException(ExceptionType.NULL_EXCEPTION, "Null message passed.");
                    }
                    if (moodMessage.Equals(string.Empty))
                    {
                        throw new MoodAnalyserCustomException(ExceptionType.EMPTY_EXCEPTION, "Empty message passed.");
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
}
