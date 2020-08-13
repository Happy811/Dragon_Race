using System;
using System.Windows.Forms;

namespace Dragon_Race
{
    public partial class DragonRaceForm : Form
    {
        Dragon[] Dragons = new Dragon[4];

        PlayerFactory pFactory = new PlayerFactory();
        Bettor[] Bettors = new Bettor[3];

        public DragonRaceForm()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack()
        {

            Dragon.StartingPosition1 = Dragon1.Right - racetrack.Left;
            Dragon.RacetrackLength1 = racetrack.Size.Width - 70; //fixing length of race - till finish line

            Dragons[0] = new Dragon() { DragonPictureBox = Dragon1 };
            Dragons[1] = new Dragon() { DragonPictureBox = Dragon2 };
            Dragons[2] = new Dragon() { DragonPictureBox = Dragon3 };
            Dragons[3] = new Dragon() { DragonPictureBox = Dragon4 };

            Bettors[0] = pFactory.getBettor("Happy", MaximumBet, HappyBet); //getting Happy object from factory class
            Bettors[1] = pFactory.getBettor("Suman", MaximumBet, SumanBet); //getting Suman object from factory class
            Bettors[2] = pFactory.getBettor("Nav", MaximumBet, NavBet); //getting Nav object from factory class


            foreach (Bettor bettor in Bettors)
            {
                bettor.UpdateLabels();
            }
        }

        private void HappyButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(Bettors[0].money);
        }

        private void SumanButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(Bettors[1].money);
        }

        private void NavButton_CheckedChanged(object sender, EventArgs e)
        {
            setMaximumBetTextLabel(Bettors[2].money);
        }

        private void setMaximumBetTextLabel(int Cash)
        {
            MaximumBet.Text = string.Format("Maximum Bet: ${0}", Cash);
        }

        // setting the bet for each Punter and updating labels respectively
        private void Bets_Click(object sender, EventArgs e)
        {
            int PunterNum = 0;

            if (HappyButton.Checked)
            {
                PunterNum = 0;
            }
            if (SumanButton.Checked)
            {
                PunterNum = 1;
            }
            if (NavButton.Checked)
            {
                PunterNum = 2;
            }

            Bettors[PunterNum].PlaceBet((int)BettingAmount.Value, (int)DragonNumber.Value);
            Bettors[PunterNum].UpdateLabels();
        }

        private void race_Click(object sender, EventArgs e)
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
            {  //stop punters from betting if they run out of cash
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

        private void racetrack_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Dragon3_Click(object sender, EventArgs e)
        {

        }
    }
}
