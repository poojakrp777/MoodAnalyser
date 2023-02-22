using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace TestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMood_WhenSad_ShouldReturn_SAD_MOOD()
        {
            {
                //Arrange
                string moodMessage = "I am in Sad Mood";
                MoodAnalyserProblem moodAnalyzer = new MoodAnalyser.MoodAnalyserProblem();

                string expected = "SAD";

                //Act
                string actual = moodAnalyzer.AnalyseMood(moodMessage);

                //Assert
                Assert.AreEqual(expected, actual);
            }


        }
        [TestMethod]

        public void GivenMood_WhenHappy_ShouldReturn_HAPPY_MOOD()
        {
            //Arrange
            string moodMessage = "I am in Happy Mood";
            MoodAnalyserProblem moodAnalyzer = new MoodAnalyser.MoodAnalyserProblem();
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyzer.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}