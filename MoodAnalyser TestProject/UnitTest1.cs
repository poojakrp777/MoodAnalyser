using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using static MoodAnalyser.MoodAnalyserProblem;

namespace TestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMood_WhenSad_ShouldReturn_SAD_MOOD()
        {
            //Arrange
            string moodMessage = "I am in Sad Mood";
            MoodAnalyserProblem moodAnalyser = new MoodAnalyserProblem();
            string expected = "SAD";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenHappy_ShouldReturn_HAPPY_MOOD()
        {
            //Arrange
            string moodMessage = "I am in Any Mood";
            MoodAnalyserProblem moodAnalyser = new MoodAnalyserProblem();
            string expected = "HAPPY";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenNull_ShouldReturn_Null_MOOD_EXCEPTION_MESSAGE()
        {
            //Arrange
            string moodMessage = null;
            MoodAnalyserProblem moodAnalyser = new MoodAnalyserProblem();
            string expected = "Null message passed.";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenMood_WhenEmpty_ShouldReturn_EMPTY_MOOD_EXCEPTION_MESSAGE()
        {
            //Arrange
            string moodMessage = string.Empty;
            MoodAnalyserProblem moodAnalyser = new MoodAnalyserProblem();
            string expected = "Empty message passed.";

            //Act
            string actual = moodAnalyser.AnalyseMood(moodMessage);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //TC-4.1 Returns the mood analyser object
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturns_MoodAnalyserObject()
        {
            object expected = new MoodAnalyserProblem();
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyzerProblems", "MoodAnalyzerProblems");
            expected.Equals(obj);
        }
        // TC-4.2 should throw NO_SUCH_CLASS exception.
        [TestMethod]
        public void GivenImproperClassName_Shouldthrow_MoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                MoodAnalyserProblem moodAnalyser = new MoodAnalyserProblem();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyzerProblems", "MoodAnalyzerProblems");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //TC-4.3 should throw NO_SUCH_CONTRUCTOR exception.
        [TestMethod]
        public void GivenImproperConstructor_Shouldthrow_MoodAnalysisException()
        {
            string expected = "Constructor is Not Found";
            try
            {
                MoodAnalyserProblem moodAnalyser = new MoodAnalyserProblem();
                object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyzer.MoodAnalyzerProblems", "MoodAnalyzer");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //TC 5.1 :  Given MoodAnalyser Class Name When Proper Should Returns MoodAnalyser Object
        [TestMethod]
        public void GivenMoodAnalyserClassName_WhenProper_ShouldReturns_MoodAnalyserObject()
        {
            object expected = new MoodAnalyserProblem("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyser.Mood_Analyser_Problems", "Mood_Analyser_Problems", "HAPPY");
            expected.Equals(obj);
        }

        // TC 5.2 : Given Class Name When Improper Should Throw MoodAnalysis Exception.
        [TestMethod]
        public void GivenClassName_WhenImproper_ShouldThrow_MoodAnalysisException()
        {
            string expected = "Class is Not Found";
            try
            {
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyser.Mood_Analyser_Problems", "Mood_Analyser_Problems", "HAPPY");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        // TC 5.3 : Given Constructor Name When Improper Should Throw MoodAnalysisException.
        [TestMethod]
        public void GivenConstructorName_WhenImproper_Shouldthrow_MoodAnalysisException()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyser.Mood_Analyser_Problems", "Mood_Analyser_Problems", "HAPPY");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //  TC 6.1 Given happy message using reflection when proper should return happy mood.
        [TestMethod]
        public void GivenHappyMessage_WhenUsingReflection_ThenShouldReturnHappyMood()
        {
            string expected = "Happy";
            object obj = MoodAnalyserFactory.InvokeAnalyseMood("Happy", "AnalyseMood");
            Assert.AreEqual(expected, obj);
        }

        //  TC 6.2 Given happy message when improper method should throw Mood Analysis Exception.
        [TestMethod]
        public void GivenHappyMessage_WhenImproperMethod_ShouldThrow_MoodAnalysisException()

        {
            string expected = "Method is not found";
            try
            {
                object obj = MoodAnalyserFactory.InvokeAnalyseMood("Happy", "WrongAnalyseMood");
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}