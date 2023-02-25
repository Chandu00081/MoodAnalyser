using NUnit.Framework;
using MoodAnalyser;

namespace TestProject1
{
    public class UnitTest1
    {
        [SetUp]
        public void GivenSadMoodMessage_WhenAnalyse_ShouldReturnSAD();
        public void Setup()
        {
            string message = "I am sad mood";
            string expectedValue = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            string result = moodAnalyser.AnalyseMood(message);

            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        public void GivenSadMoodMessage_WhenAnalyse_ShouldReturnHAPPY()
        {

            string message = "I am happy mood";
            string expectedValue = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string result = moodAnalyser.AnalyseMood(message);
            Assert.AreEqual(expectedValue, result);
        }

    }
}