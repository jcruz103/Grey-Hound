using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using A_Day_at_the_Races;

namespace A_Day_at_the_Races
{
    class Greyhound
    {
        public int StartingPosition = 0;
        public int RacetrackLength = 242;
        public PictureBox MyPictureBox = null;
        public int Location;
        public Random Randomizer;

        public bool Run()
        {
            Randomizer = new Random();
            int distance = Randomizer.Next(50);

            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            Location = p.X;
            

            MyPictureBox.Update();

            if (RacetrackLength <= Location)
            {
                MessageBox.Show("Test");
                return true;
            }
            else
                return false;
        }// end of run

        public void TakeStartingPosition()
        {
            Location = 0;
            Point p = MyPictureBox.Location;
            p.X = -1;
            MyPictureBox.Update();

        }// end of takestartingposition

    }// end of greyhound

}
