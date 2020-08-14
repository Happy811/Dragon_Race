using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dragon_Race
{
    public class Dragon
    {
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get; set; }
        public static int RacetrackLength1 { get; set; }
        public PictureBox DragonPictureBox { get; set; } = null;

        // generation across all  Dragon objects

        public static bool Run(Dragon obj)
        {
            int distance = MyRandom.Next(1, 10);
            if (obj.DragonPictureBox != null)
                obj.MoveDragonPictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1))
            {
                return true;
            }
            return false;
        }

        public void StartPosition()
        {
            MoveDragonPictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveDragonPictureBox(int distance)
        {
            Point p = DragonPictureBox.Location;
            p.X += distance;
            DragonPictureBox.Location = p; //move  Dragon in x-axis
        }
    }
}
