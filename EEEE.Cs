using System;
using System.Threading;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigData ConfigData = new ConfigData();
            TextGame TextGame = new TextGame();

            for(int i = 0; i !=  ConfigData.numberOfEvents; i++)
            {
                TextGame.CheckIfCorrect(ConfigData.question[i], ConfigData.correctResponse[i], ConfigData.inncorrectResponse[i], ConfigData.yesOrNo[i]);
            }
            Environment.Exit(0);
        }
    }

}
