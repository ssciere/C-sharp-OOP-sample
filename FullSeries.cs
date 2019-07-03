using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class FullSeries

    {
        
        static public void fullSeries()

        {

            // the next three lines can all be changed in the GameSettings class
            int winsNeededToWinSeries = GameSettings.winsNeededToWinSeries;
            string userPlayerName = GameSettings.userPlayerName;
            string computerPlayerName = GameSettings.ComputerPlayerName;

            int userGamesWon = 0;
            int computerGamesWon = 0;
            Console.WriteLine("Let's start the series. Good Luck!");
            while (userGamesWon < winsNeededToWinSeries && computerGamesWon < winsNeededToWinSeries) //stay in loop til someone wins 4 games
            {
                string winner = SingleGame.oneGame(userGamesWon, computerGamesWon); //call for a game to be played and have the winner returned
                
                if (winner == "user") // add a "game won" to the winner's total
                {
                    RecordBook.UpdateRecordBook("won_game"); //update the record books
                    userGamesWon ++; }

                else                    
                {                    
                    RecordBook.UpdateRecordBook("lost_game"); //update the record books
                    computerGamesWon++;
                }

             }

            if (userGamesWon > computerGamesWon) //names winner when someone gets to number needed to win series
            {
                RecordBook.UpdateRecordBook("won_series"); //update the record books
                Console.WriteLine("{0} wins the series!",userPlayerName);

            }
            else
            {
                RecordBook.UpdateRecordBook("lost_series"); //update the record books
                Console.WriteLine("{0} wins the series!",computerPlayerName);

            }
            Console.WriteLine("");
            Console.WriteLine("Press the 'P' key + <enter> to play again or the 'Q' key + <enter> to get final stats and quit");

            string playChoice = "";
            while (true)
                {
                playChoice = Console.ReadLine().Trim(); //takes user's input
                string isInputValid = Validation.validate(playChoice, "p", "q"); // calls validation class, sends users choice and possible valid choices

                //if Validation.validate returns a NULL string there is no error.  If it returns a customer error message the error is written and loop continues

                if (isInputValid is null)
                    {
                    break;
                }
                else
                {
                    Console.WriteLine(isInputValid); 
                }
            }
            

            if (playChoice == "P" || playChoice == "p")
            {
                FullSeries.fullSeries(); 
            }

            else

            {
                GoodBye.goodbye();
            }




        }





    }
}
