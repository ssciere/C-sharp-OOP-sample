using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class IntroMessage
    {
        static public void introMessage()
            //playernames and number of games per series can be changed in GameSettings class
        {   string userPlayerName = GameSettings.userPlayerName;
            string computerPlayerName = GameSettings.ComputerPlayerName;
            int winsNeededToWinSeries = GameSettings.winsNeededToWinSeries;

            Console.WriteLine("***WELCOME TO THE  GUESSING GAME***");
            Console.WriteLine("You will be {0}. See if you can guess", userPlayerName);
            Console.WriteLine("the number {0} is thinking.", computerPlayerName);
            Console.WriteLine("The first player to win {0} times takes the series!", winsNeededToWinSeries);
            Console.WriteLine("");
            FullSeries.fullSeries(); //starts the first "best of" series

            




        }

    }
}
