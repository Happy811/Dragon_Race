using Dragon_Race;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dragon_RaceTest
{
    [TestClass]
    public class Dragon_RaceUnitTest
    {
        PlayerFactory objFactory = new PlayerFactory();
        Bettor Happy
            ;
        Dragon[] Dragons = new Dragon[2];

        [TestMethod]
        public void TestWinnerOutcome()
        {
            Dragon.StartingPosition1 = 0;
            Dragon.RacetrackLength1 = 50;
            int BettingAmount = 50;
            int DragonNumber = 1;
            int expectedWin = 100;
            int expectedLose = 0;
            Dragons[0] = new Dragon() { DragonPictureBox = null };
            Dragons[1] = new Dragon() { DragonPictureBox = null };
            Happy = objFactory.getBettor("Happy", null, null);
            Happy.money = BettingAmount;
            Happy.PlaceBet((int)BettingAmount, DragonNumber);

            bool nowin = true;
            int win = -1;
            while (nowin)
            {
                for (int i = 0; i < Dragons.Length; i++)
                {
                    if (Dragon.Run(Dragons[i]))
                    {
                        win = i + 1;
                        Happy.Collect(win);
                        nowin = false;

                    }
                }
            }
            if (Happy.gamble.DragonNum == win)
            {
                Assert.AreEqual(expectedWin, Happy.money, "Account not credited correctly");
            }
            if (Happy.gamble.DragonNum != win)
            {
                Assert.AreEqual(expectedLose, Happy.money, "Account not debited correctly");

            }
        }
    }

}
