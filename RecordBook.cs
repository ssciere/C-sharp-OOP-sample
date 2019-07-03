
using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class RecordBook
    {
        /*RecordBook Class counts total games won and series won by the user and decides if they get an
        award. If statements are structured so user is only awarded the best award they won   */


        protected int winsNeededForAward;
        protected string nameOfAward;

        

        protected RecordBook(int aWinsNeededForAward, string aNameOfAward)
        {

            winsNeededForAward = aWinsNeededForAward;
            nameOfAward = aNameOfAward;


        }

        //counts number of games and series user has won for entire session
        private static int totalGamesWon = 0;
        private static int totalGamesLost = 0;
        private static int totalSeriesWon = 0;
        private static int totalSeriesLost = 0;


        static public void UpdateRecordBook(string whatHappened)  //method to increase win totals
        {
            if (whatHappened == "won_game") { totalGamesWon++; }
            if (whatHappened == "lost_game") { totalGamesLost++; }
            if (whatHappened == "won_series") { totalSeriesWon++; }
            if (whatHappened == "lost_series") { totalSeriesLost++; }
        }

        static public string getFinalStatLine() //method to pull final win totals for display to user

        {
            string finalStatLine = "You won " + totalGamesWon + " games and lost " + totalGamesLost
                + ". \nYou won " + totalSeriesWon + " series and lost " + totalSeriesLost + ".";
            

            return finalStatLine;

        }


        static public string checkForHallOfFameAward() //method to check for award won to display to user
        {
            RecordBook seriesAwards = new RecordBook(6, "All Time Great Hall of Famer");
            RecordBook gameAwards = new RecordBook(2, "Gamer Hall of Fame Award");

            string awardToReturn = null; //if this reamains null (no award won) the calliing method should not post mention of awards
            if (totalSeriesWon >= seriesAwards.winsNeededForAward) //decides if user won enough series to win an award
            {
                awardToReturn = "All Time Great Hall of Famer";
                return awardToReturn;
                
            }
            else
            {
                if (totalGamesWon >= gameAwards.winsNeededForAward) //decides if user won enough games to win award
                {
                    awardToReturn = "Great Player Award";
                    return awardToReturn;
                }
                else return null;
            }

           
        }
    }
}
       


       

       



