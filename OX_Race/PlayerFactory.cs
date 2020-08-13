using System;
using System.Windows.Forms;

namespace Dragon_Race
{
    public class PlayerFactory
    {
        public Bettor getBettor(String Name, Label MaximumBet, Label bet)
        {
            Bettor p;
            switch (Name.ToLower())
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
            p.setBettorName();
            return p;
        }
    }
}
