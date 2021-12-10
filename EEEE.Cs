using System;
using System.Threading;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            TextGame TextGame = new TextGame();

            for(int i = 0; i !=  5; i++)
            {
                TextGame.CheckIfCorrect(TextGame.question[i], TextGame.correctResponse[i], TextGame.inncorrectResponse[i], TextGame.yesOrNo[i]);
            }
            Thread.Sleep(5000);
            Console.Clear();
        }
    }

}
