using System;

namespace MPclass
{
    class TextGame
    {
        static private bool[] YesOrNo = { true, false, false, true, false };
        static private string[] CorrectResponse = { "You win 1", "You win 2", "You win 3", "You win 4", "You win 5" };
        static private string[] InncorrectResponse = { "You lose 1", "You lose 2", "You lose 3", "You lose 4", "You lose 5" };
        static private string[] Question = { "Question 1", "Question 2", "Question 3", "Question 4", "Question 5" };

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
    }
}