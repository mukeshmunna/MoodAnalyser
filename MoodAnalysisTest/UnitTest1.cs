using MoodAnalyserProblem;

namespace MoodAnalysisTest
{
    public class Tests
    {
        
        [Test]
        public void GivenSadMessage_WhenAnalsyse_SholudReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual = analyser.AnalayseMood();
            Assert.AreEqual(actual, "SAD");
        }
        [Test]
        public void GivenHappyMessage_WhenAnalsyse_SholudReturnSad()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual1 = analyser.AnalayseMood();
            Assert.AreEqual(actual1, "HAPPY");
        }
        [Test]
        public void GivenNullMessage_WhenAnalsyse_SholudReturnSad()
        {
            string message = "I am in Null Mood";
            MoodAnalyser analyser = new MoodAnalyser(message);
            string actual1 = analyser.AnalayseMood();
            Assert.AreEqual(actual1, "HAPPY");
        }
    }
}