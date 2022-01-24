using System;
using System.Threading;

namespace C_
{
    class TextGame
    {
        ConfigData ConfigData = new ConfigData();
        private bool CheckResponse()
        {
            bool returnValue = false;
            while(true)
            {
            string response = Console.ReadLine().ToLower();
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
                Environment.Exit(0);
            }
        }
    }
}
