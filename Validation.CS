using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class Validation //used for all validation, overload allows for 2 or 3 arguments. validation is not case sensitive
    {
        static public string validate(string userEntry, string validEntry1, string validEntry2)
        {

            if (string.Compare(userEntry, validEntry1, true) == 0 ||
                string.Compare(userEntry, validEntry2, true) == 0)
            {
                return null; //returns a null string if input is valid
            }
            else
            {         //returns error message to be used if input is not valid
                return "Invalid input.  Please press the " + validEntry1.ToUpper() + " or " + validEntry2.ToUpper() + " key + <enter>.";
            }

        }
    

    static public string validate(string userEntry, string validEntry1, string validEntry2, string validEntry3)
    {

        if (string.Compare(userEntry, validEntry1, true) == 0  ||
            string.Compare(userEntry, validEntry2, true) == 0 ||
            string.Compare(userEntry, validEntry3, true) == 0)
        {
            return null; //returns a null string if input is valid
        }
        else
        {         //returns error message to be used if input is not valid
            return "Invalid input.  Please press the " + validEntry1.ToUpper() + ", " + validEntry2.ToUpper() + " or " + validEntry3.ToUpper() + " key + <enter>.";
        }

    }

    }
}
