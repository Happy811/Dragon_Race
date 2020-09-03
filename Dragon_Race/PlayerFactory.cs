using System;
using System.Windows.Forms;

namespace Dragon_Race
{
    public static class PlayerFactory
    {
        public static Bettor GetBettor(String Name, Label MaximumBet, Label bet)
        {
            Bettor b;
            switch (Name) 
            {
                case "Happy":
                    b = new Happy(null, MaximumBet, 50, bet);
                    break;

                case "Suman":
                    b = new Suman(null, MaximumBet, 50, bet);
                    break;

                case "Nav":
                    b = new Nav(null, MaximumBet, 50, bet);
                    break;

                default:
                    b = null;
                    break;
            }
            
            return b;
        }
    }
}
