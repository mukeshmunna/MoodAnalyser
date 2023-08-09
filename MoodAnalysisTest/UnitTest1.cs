using MoodAnalyserProblem;
using MoodAnalysisProblem;

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
            string actual = analyser.AnalayseMood();
            Assert.AreEqual(actual, "HAPPY");
        }

        [Test]
        public void GivenNullMessage_WhenAnalsyse_SholudReturnHappy()
        {
            string message = null;
            MoodAnalyser analyser = new MoodAnalyser(message);
            try
            {
                string actual = analyser.AnalayseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        [Test]
        public void GivenEmptyMessage_WhenAnalsyse_SholudReturnSad()
        {
            string message = "";
            MoodAnalyser analyser = new MoodAnalyser(message);
            try
            {
                string actual = analyser.AnalayseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }
    }
}
