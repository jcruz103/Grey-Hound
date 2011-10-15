using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    public partial class Form1 : Form
    {
        Greyhound grey = new Greyhound();
        Greyhound[] greyArray = new Greyhound[4];
        Guy[] guyArray = new Guy[3];
        Guy guy = new Guy();
        Bet bet = new Bet();





        public Form1()
        {
            InitializeComponent();
            guyArray[0] = new Guy() { Name = "Joe", Cash = 100, MyRadioButton = joeButton };           
            guyArray[1] = new Guy() { Name = "Bob", Cash = 100, MyRadioButton = BobButton };            
            guyArray[2] = new Guy() { Name = "Al", Cash = 100, MyRadioButton = alButton };

            //Guy Joe = guyArray[0];
            //Guy Bob = guyArray[1];
            //Guy Al = guyArray[2];
            

            greyArray[0] = new Greyhound() { StartingPosition = 0, RacetrackLength = RaceTrack.Image.Width, MyPictureBox = GreyHoundPicutre1, Location = 0 };
            greyArray[1] = new Greyhound() { StartingPosition = 0, RacetrackLength = RaceTrack.Image.Width, MyPictureBox = GreyHoundPicutre2, Location = 0 };
            greyArray[2] = new Greyhound() { StartingPosition = 0, RacetrackLength = RaceTrack.Image.Width, MyPictureBox = GreyHoundPicutre3, Location = 0 };
            greyArray[3] = new Greyhound() { StartingPosition = 0, RacetrackLength = RaceTrack.Image.Width, MyPictureBox = GreyHoundPicutre4, Location = 0 };


        }
        
        private void joeButton_CheckedChanged(object sender, EventArgs e)
        {
            whoIsBetting.Text = "Joe";
        }

        private void BobButton_CheckedChanged(object sender, EventArgs e)
        {
            whoIsBetting.Text = "Bob";
        }

        private void alButton_CheckedChanged(object sender, EventArgs e)
        {
            whoIsBetting.Text = "Al";
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            bool done = false;

            while (!done)
            {
                int j = 0;

                for (int i = 0; i < greyArray.Length; i++)
                {

                    done = greyArray[j].Run();
                    j++;

                    if (done)
                    {
                        bet.PayOut(dogWinner: j);
                        break;
                    }
                }

                //guyArray[0].Collect(Winner: guyArray[0].MyBet.Dog);
                //guyArray[1].Collect(Winner: guyArray[1].MyBet.Dog);
                //guyArray[2].Collect(Winner: guyArray[2].MyBet.Dog);
                //guyArray[0].winDog = j;
                guyArray[0].Collect(j);

                //guyArray[1].winDog = j;
                guyArray[1].Collect(j);

               // guyArray[2].winDog = j;
                guyArray[2].Collect(j);

                break;

            }
                 /*
                bool done = false;

                while (!done)
                {
                    int j = 0;

                    for (int i = 0; i < greyArray.Length; i++)
                    {
                        
                        done = greyArray[j].Run();
                        j++;
                        bet.PayOut(dogWinner: j);
                        if (done)
                            break;
                    }

                    //guyArray[0].Collect(Winner: guyArray[0].MyBet.Dog);
                    //guyArray[1].Collect(Winner: guyArray[1].MyBet.Dog);
                    //guyArray[2].Collect(Winner: guyArray[2].MyBet.Dog);
                    guyArray[0].winDog = j;
                    guyArray[0].Collect(Winner: guyArray[0].MyBet.Dog);

                    guyArray[1].winDog = j;
                    guyArray[1].Collect(Winner: guyArray[1].MyBet.Dog);

                    guyArray[2].winDog = j;
                    guyArray[2].Collect(Winner: guyArray[2].MyBet.Dog);

                    break;
                    
                }
            */
            /*
            bool done = false;
            int j = 0;
            while (!done)
            {

                    for (int i = 0; i < greyArray.Length; i++)
                    {

                        done = greyArray[j].Run();

                        if (done)
                        {

                            bet.PayOut(j);
                            break;
                        }
                        j++;
                    }
                

            }
            guyArray[0].Collect(j);
            guyArray[1].Collect(j);
            guyArray[2].Collect(j);
            */
        }

        private void GreyHoundPicutre1_Click(object sender, EventArgs e)
        {

        }

        private void whoIsBetting_Click(object sender, EventArgs e)
        {
            
            

            
        }

        private void betButton_Click(object sender, EventArgs e)
        {


            if (joeButton.Checked)
            {
                joeLabel.Text = "Joe betted " + (int)betNumericUpDown1.Value + " on dog " + (int)dogNumericUpDown2.Value;
                guyArray[0].Updatelabels();
                guyArray[0].PlaceBet(Amount: (int)betNumericUpDown1.Value, Dog: (int)dogNumericUpDown2.Value);
                
                
            }

            if (BobButton.Checked)
            {
                bobLabel.Text = "Bob betted " + (int)betNumericUpDown1.Value + " on dog " + (int)dogNumericUpDown2.Value;

                guyArray[1].Updatelabels();
                guyArray[1].PlaceBet(Amount: (int)betNumericUpDown1.Value, Dog: (int)dogNumericUpDown2.Value);
                
            }

            if (alButton.Checked)
            {
                alLabel.Text = "AL betted " + (int)betNumericUpDown1.Value + " on dog " + (int)dogNumericUpDown2.Value;

                guyArray[2].Updatelabels();
                guyArray[2].PlaceBet(Amount: (int)betNumericUpDown1.Value, Dog: (int)dogNumericUpDown2.Value);
               
            }

            
            
        }

    }
}
