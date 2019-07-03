using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class BasicTips
        //just an example of a base class
    {
        protected string seriousTip;
        protected string funnyTip;

        protected BasicTips(string aSeriousTip, string aFunnyTip)
        {

            seriousTip = aSeriousTip;
            funnyTip = aFunnyTip;


        }

     public virtual void goodbye() //just an example of Polymorphism
        {
            Console.WriteLine("Thanks for Playing");
        }
    }
}
