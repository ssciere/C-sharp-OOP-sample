using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class GoodBye
    {
        static public void goodbye()
        {
            string finalStatLine = RecordBook.getFinalStatLine(); //gets games, series won from RecordBook
            Console.WriteLine(finalStatLine); 
            string award = RecordBook.checkForHallOfFameAward(); //checks for an award
            if (award != null)  //displays the award only if award was won
            {
                Console.WriteLine("Congrats! You won the " + award + "!");
            }

            string proTips = ProTips.getProandBasicTips(); //gets tips from ProTips class (derived from BasicTips)
            Console.WriteLine("Here are some final tips:"); 
            Console.WriteLine(proTips); //display tips
            Console.WriteLine("");
            Console.WriteLine("Thanks for Playing. Good-bye!");
            Console.ReadLine();
        }
    }
}
