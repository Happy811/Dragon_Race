using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Dragon_Race
{
    public partial class DragonRaceForm : Form
    {
        readonly Dragon[] Dragons = new Dragon[4];

        readonly Bettor[] Bettors = new Bettor[3];

        public DragonRaceForm()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack()
        {

            Dragon.StartingPosition1 = Dragon1.Right - Racetrack.Left;
            Dragon.RacetrackLength1 = Racetrack.Size.Width - 70; //fixing length of race - till finish line

            Dragons[0] = new Dragon() { DragonPictureBox = Dragon1 };
            Dragons[1] = new Dragon() { DragonPictureBox = Dragon2 };
            Dragons[2] = new Dragon() { DragonPictureBox = Dragon3 };
            Dragons[3] = new Dragon() { DragonPictureBox = Dragon4 };

            Bettors[0] = PlayerFactory.GetBettor("Happy", MaximumBet, HappyBet); //getting Happy object from factory class
            Bettors[1] = PlayerFactory.GetBettor("Suman", MaximumBet, SumanBet); //getting Suman object from factory class
            Bettors[2] = PlayerFactory.GetBettor("Nav", MaximumBet, NavBet); //getting Nav object from factory class

            Debug.WriteLine(Bettors[0].Title);

            foreach (Bettor bettor in Bettors)
            {
                bettor.UpdateLabels();
            }
        }

        private void HappyButton_CheckedChanged(object sender, EventArgs e)
        {
            SetMaximumBetTextLabel(Bettors[0].money);
        }

        private void SumanButton_CheckedChanged(object sender, EventArgs e)
        {
            SetMaximumBetTextLabel(Bettors[1].money);
        }

        private void NavButton_CheckedChanged(object sender, EventArgs e)
        {
            SetMaximumBetTextLabel(Bettors[2].money);
        }

        private void SetMaximumBetTextLabel(int Cash)
        {
            MaximumBet.Text = string.Format("Maximum Bet: ${0}", Cash);
        }

        // setting the bet for each Bettor and updating labels respectively
        private void Bets_Click(object sender, EventArgs e)
        {
            int BettorNum = 0;

            if (HappyButton.Checked)
            {
                BettorNum = 0;
            }
            if (SumanButton.Checked)
            {
                BettorNum = 1;
            }
            if (NavButton.Checked)
            {
                BettorNum = 2;
            }

            Bettors[BettorNum].PlaceBet((int)BettingAmount.Value, (int)DragonNumber.Value);
            Bettors[BettorNum].UpdateLabels();
        }

        private void Race_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningDragon;
            race.Enabled = false; //disable start race button

            while (NoWinner)
            { // loop until we have a winner
                Application.DoEvents();
                for (int i = 0; i < Dragons.Length; i++)
                {
                    if (Dragon.Run(Dragons[i]))
                    {
                        winningDragon = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner -  Dragon #" + winningDragon);
                        foreach (Bettor bettor in Bettors)
                        {
                            if (bettor.gamble != null)
                            {
                                bettor.Collect(winningDragon); //give double amount to all who've won or deduce betted amount
                                bettor.gamble = null;
                                bettor.UpdateLabels();
                            }
                        }
                        foreach (Dragon Dragon in Dragons)
                        {
                            Dragon.StartPosition();
                        }
                        break;
                    }
                }
            }
            if (Bettors[0].busted && Bettors[1].busted && Bettors[2].busted)
            {  //stop bettors from betting if they run out of cash
                string message = "Do you want to Play Again?";
                string title = "GAME OVER!";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    SetupRaceTrack(); //restart game
                }
                else
                {
                    Close();
                }

            }
            race.Enabled = true; //enable race button 
        }

        private void Racetrack_Click(object sender, EventArgs e)
        {

        }

        private void Dragon4_Click(object sender, EventArgs e)
        {

        }

        private void SumanBet_Click(object sender, EventArgs e)
        {

        }

        private void NavBet_Click(object sender, EventArgs e)
        {

        }

        private void BettingAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Dragon3_Click(object sender, EventArgs e)
        {

        }
    }
}
