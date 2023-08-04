namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalayseMood()
        {
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }

    }
}