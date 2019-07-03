using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame

    /* This class generates tips to provide the user.  (Also serves as an example of inheritance)*/
{
    class ProTips : BasicTips
    {
        private string proTip;
        public ProTips(string aSeriousTip, string aFunnyTip, string aProTip)
            :base(aSeriousTip,aFunnyTip)
        {
            proTip = aProTip;
        }

        static public string getProandBasicTips() //method to create a string of tips to send back to user
        {
            ProTips usersTips = new ProTips("Don't worry if you lost. It's just a game.", "Don't ever eat snow.", "Guess better next time.");
            string allTips = (usersTips.seriousTip + "\n" + usersTips.funnyTip + "\n" + usersTips.proTip);
            return allTips;
        }

        public override void goodbye() //just an example of Polymorphism
        {
            base.goodbye();
            Console.WriteLine("Have a great day!"); //adds a second message to base
        }

    }
}
