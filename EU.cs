using System;
using System.Threading;

namespace C_
{
    class TextGame
    {
        static private bool[] YesOrNo = { true, false, false, true, false };
        static public bool[] yesOrNo;
        static private string[] CorrectResponse = { "You win 1", "You win 2", "You win 3", "You win 4", "You win 5, congrats you did it!" };
        static public string[] correctResponse;
        static private string[] InncorrectResponse = { "You lose 1", "You lose 2", "You lose 3", "You lose 4", "You lose 5" };
        static public string[] inncorrectResponse;
        static private string[] Question = { "Question 1", "Question 2", "Question 3", "Question 4", "Question 5" };
        static public string[] question;

        private bool CheckResponse()
        {
            bool returnValue = false;
            string response = Console.ReadLine().ToLower();
            while(true)
            {
            if(response == "y")
            {
                returnValue = true;
                break;
            } 
            else if(response == "n")
            {
                returnValue = false;
                break;
            }
            }

            return returnValue;

        }
        public void CheckIfCorrect( string startingMessage, string passed, string failed, bool yOrN )
        {
            Console.WriteLine(startingMessage);
            bool response = CheckResponse();
            if(response == yOrN)
            {
                Console.WriteLine(passed);
            }
            else
            {
                Console.WriteLine(failed);
                Thread.Sleep(5000);
                Console.Clear();
            }
        }

        public TextGame()
        {
            yesOrNo = YesOrNo;
            correctResponse = CorrectResponse;
            inncorrectResponse = InncorrectResponse;
            question = Question;
        }
    }
}