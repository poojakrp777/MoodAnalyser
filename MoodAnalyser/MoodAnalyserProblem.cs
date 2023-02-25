using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    throw new NullReferenceException();
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
            catch (NullReferenceException ex)
            {
                return "HAPPY";
            }

        }
    }
}
