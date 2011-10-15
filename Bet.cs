using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A_Day_at_the_Races
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        public int dogWinner;


        public void Payout()
        {
            Bettor.Cash = Bettor.Cash += Amount;
        }

        public void reduce()
        {
            Bettor.Cash = Bettor.Cash -= Amount;
            
        }
        
        public int PayOut(int dogWinner)
        {
            //Guy guy = new Guy();
            this.dogWinner = dogWinner;
            Guy winner = new Guy() { winDog = dogWinner };
            
            return dogWinner;
             
        }

        
        
    }// end of bet

}
