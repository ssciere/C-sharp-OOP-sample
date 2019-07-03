using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class SingleGame //represents a single guess as part of a "best of series"
    {
        static public string oneGame(int userScore, int computerScore)
        {
            string userPlayerName = GameSettings.userPlayerName;
            string computerPlayerName = GameSettings.ComputerPlayerName;
            Random r = new Random();
            string winner = "";
            int randomNumber = r.Next(1, 3); //generates a random number between one and two
            string computersGuess = randomNumber.ToString(); //converting to string since guess will be entered as string


            // gives full instructions for first guess then short instructions once total score is no longer zero
            if (userScore + computerScore == 0)
            {
                Console.WriteLine("Make your guess.  Press 1 or 2 then press <enter>");
            }
            else
            {
                Console.WriteLine("Enter your next guess ");
            }

            string usersGuess = "";
            while (true)
            {
                usersGuess = (Console.ReadLine()).Trim(); //takes user's input
                string isInputValid = Validation.validate(usersGuess, "1", "2"); // calls validation class, sends users choice and possible valid choices

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

            if (string.Compare(usersGuess, computersGuess, true) == 0) 

            {
                Console.WriteLine("Correct guess!");  //if user Wins
                winner = "user";
                userScore++;
            }
            else
            {
                Console.WriteLine("Incorrect guess!");  //if computer Wins
                winner = "computer";
                computerScore++;
            }

            //****Score update****
            Console.WriteLine ("SCORE: {0}: {1} *** {2}: {3}", userPlayerName, userScore, computerPlayerName, computerScore);
            Console.WriteLine("");

            return winner;


        }

    }
}
