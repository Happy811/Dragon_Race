using System;
using System.Windows.Forms;

namespace Dragon_Race
{
    public static class PlayerFactory
    {
        public static Bettor GetBettor(String Name, Label MaximumBet, Label bet)
        {
            Bettor p;
            switch (Name) 
            {
                case "Happy":
                    p = new Happy(null, MaximumBet, 50, bet);
                    break;

                case "Suman":
                    p = new Suman(null, MaximumBet, 50, bet);
                    break;

                case "Nav":
                    p = new Nav(null, MaximumBet, 50, bet);
                    break;

                default:
                    p = null;
                    break;
            }
            
            return p;
        }
    }
}
