

namespace C_
{
    class ConfigData
    {
        static private bool[] YesOrNo = { true, false, false, true, false };
        static public bool[] yesOrNo;
        static private string[] CorrectResponse = { "You win 1", "You win 2", "You win 3", "You win 4", "You win 5, congrats you did it!" };
        static public string[] correctResponse;
        static private string[] InncorrectResponse = { "You lose 1", "You lose 2", "You lose 3", "You lose 4", "You lose 5" };
        static public string[] inncorrectResponse;
        static private string[] Question = { "Question 1", "Question 2", "Question 3", "Question 4", "Question 5" };
        static public string[] question;
        static public bool failedYOrN = false;

        static public int numberOfEvents;

        public ConfigData()
        {
            yesOrNo = YesOrNo;
            correctResponse = CorrectResponse;
            inncorrectResponse = InncorrectResponse;
            question = Question;
            numberOfEvents = Question.Length;
        }
    }
}