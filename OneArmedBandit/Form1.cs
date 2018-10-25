﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        int randomValue1;
        int randomValue2;
        int randomValue3;

        // random number generator
        Random randgen = new Random();
        // int value for score initialized to 10
        int score = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            randomValue1 = randgen.Next(1, 4);
            randomValue2 = randgen.Next(1, 4);
            randomValue3 = randgen.Next(1, 4);

            // check value of reel 1 with a switch statement and set appropriate image
            switch (randomValue1)
            {
                case 1:
                    reel1.Image = Properties.Resources.Image7;
                    break;

                case 2:
                    reel1.Image = Properties.Resources.Cherry;
                    break;

                case 3:
                    reel1.Image = Properties.Resources.Diamond;
                    break;
            }
            // check value of reel 2 with a switch statement and set appropriate image
            switch (randomValue2)
            {
                case 1:
                    reel2.Image = Properties.Resources.Image7;
                    break;

                case 2:
                    reel2.Image = Properties.Resources.Cherry;
                    break;

                case 3:
                    reel2.Image = Properties.Resources.Diamond;
                    break;
            }

            // check value of reel 3 with a switch statement and set appropriate image
            switch (randomValue3)
            {
                case 1:
                    reel3.Image = Properties.Resources.Image7;
                    break;

                case 2:
                    reel3.Image = Properties.Resources.Cherry;
                    break;

                case 3:
                    reel3.Image = Properties.Resources.Diamond;
                    break;
            }

            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score. 
            //score = 10;
            //scoreDisplay.Text = score + "";
            if (randomValue1 == randomValue2 && randomValue2 == randomValue3)
            {
                outputLabel.Text = "Winner";
                score = score + 3;
               // scoreDisplay.Text = score + "";
            }
            else
            {
                outputLabel.Text = "Play Again";
                score = score - 1;
                //scoreDisplay.Text = score + "";
               
            }


            // if score has reached 0 display "lose" message and set button enabled property to false
            if(score == 0)
            {
                outputLabel.Text = "You Lost";
                spinButton.Enabled = false;
            }


            // display updated score
            scoreDisplay.Text = score + "";
        }
    }
}
