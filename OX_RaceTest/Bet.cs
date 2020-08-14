namespace Dragon_Race
{
    public class Bet
    {
        public int Amount;
        public int DragonNum;
        public  Bettor Bettor;

        public Bet(int Amount, int DragonNum, Bettor Bettor)
        {
            this.Amount = Amount;
            this.DragonNum = DragonNum;
            this.Bettor = Bettor;
        }
        public string GetDescription()
        {
            string description;
            if (Amount > 0)
            {
                description = string.Format("{0} bets {1} on OX #{2}",
                    Bettor.Title, Amount, DragonNum);
            }
            else
            {
                description = string.Format("{0} hasn't placed any bets",
                    Bettor.Title);
            }
            return description;
        }

        public int Pay(int Winner)
        {
            if (DragonNum == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
