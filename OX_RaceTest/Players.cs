using System.Windows.Forms;

namespace Dragon_Race
{
    public class Happy : Bettor
    {
        public Happy(Bet MyBet, Label MaximumBet, int Money, Label MyLabel) : base(MyBet, MaximumBet, Money, MyLabel)
        {
            Title = "Happy";
        }
    }

    public class Nav : Bettor
    {
        public Nav(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
        {
            Title = "Nav";
        }
    }

    public class Suman : Bettor
    {
        public Suman(Bet bet, Label MaximumBet, int Money, Label label) : base(bet, MaximumBet, Money, label)
        {
            Title = "Suman";
        }
        
    }
}
