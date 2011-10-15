using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A_Day_at_the_Races
{
    class Guy
    {
        Bet getter;
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        public int winDog;

        

        public void Updatelabels()
        {
            MyRadioButton.Text = Name + " has " + Cash;
        }// end of updates

        public void ClearBet()
        {
            MyLabel.Text = Name + " isn't betting anything";
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            MyBet = new Bet { Amount = Amount, Dog = Dog, Bettor = this };

            
            if (Amount <= Cash)
            {

                return true;
            }
            else
            {
                MessageBox.Show("You Don't have enough money");
                return false;
            }
        }



        public void Collect(int Winner)
        {
           
            if (Winner == winDog)
            {
                MyBet.Payout();
            }
            else
                MyBet.reduce();
        }




    }// end of guy
}
