using SlotMachine.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class SlotMachineForm : Form
    {
        /// <summary>
        /// Logan SikoraBeder
        /// Assignment 5
        /// December 8th, 2016
        /// Comp whatever the number is
        /// Game is hard
        /// </summary>

        private int playerMoney = 1000;
        private int winnings = 0;
        private int jackpot = 5000;
        private float turn = 0.0f;
        private int playerBet = 0;
        private float winNumber = 0.0f;
        private float lossNumber = 0.0f;
        private string[] spinResult;
        private string fruits = "";
        private float winRatio = 0.0f;
        private float lossRatio = 0.0f;
        private int grapes = 0;
        private int bananas = 0;
        private int oranges = 0;
        private int cherries = 0;
        private int bars = 0;
        private int bells = 0;
        private int sevens = 0;
        private int blanks = 0;

        private Random random = new Random();

        public SlotMachineForm()
        {
            InitializeComponent();
        }

        /* Utility function to show Player Stats */
        private void showPlayerStats()
        {
            winRatio = winNumber / turn;
            lossRatio = lossNumber / turn;
            string stats = "";
            stats += ("Jackpot: " + jackpot + "\n");
            stats += ("Player Money: " + playerMoney + "\n");
            stats += ("Turn: " + turn + "\n");
            stats += ("Wins: " + winNumber + "\n");
            stats += ("Losses: " + lossNumber + "\n");
            stats += ("Win Ratio: " + (winRatio * 100) + "%\n");
            stats += ("Loss Ratio: " + (lossRatio * 100) + "%\n");
            MessageBox.Show(stats, "Player Stats");
        }

        /* Utility function to reset all fruit tallies*/
        private void resetFruitTally()
        {
            grapes = 0;
            bananas = 0;
            oranges = 0;
            cherries = 0;
            bars = 0;
            bells = 0;
            sevens = 0;
            blanks = 0;
        }

        /* Utility function to reset the player stats */
        private void resetAll()
        {
            playerMoney = 1000;
            winnings = 0;
            jackpot = 5000;
            turn = 0;
            playerBet = 0;
            winNumber = 0;
            lossNumber = 0;
            winRatio = 0.0f;
            WinnerTextBox.Text = winNumber.ToString("C");
            BetTextBox.Text = playerBet.ToString("C");
            CreditsTextBox.Text = playerMoney.ToString("C");
        }

        /* Check to see if the player won the jackpot */
        private void checkJackPot()
        {
            /* compare two random values */
            var jackPotTry = this.random.Next(51) + 1;
            var jackPotWin = this.random.Next(51) + 1;
            if (jackPotTry == jackPotWin)
            {
                MessageBox.Show("You Won the $" + jackpot + " Jackpot!!","Jackpot!!");
                playerMoney += jackpot;
                jackpot = 1000;
                CreditsTextBox.Text = playerMoney.ToString("C");
                JackPotTextBox.Text = jackpot.ToString("C");
            }
        }

        /* Utility function to show a win message and increase player money */
        private void showWinMessage()
        {
            playerMoney += winnings;
            //possibly remove this part later
            WinnerTextBox.Text = winnings.ToString("C");
            //MessageBox.Show("You Won: $" + winnings, "Winner!");
            CreditsTextBox.Text = playerMoney.ToString("C");
            resetFruitTally();
            checkJackPot();
        }

        /* Utility function to show a loss message and reduce player money */
        private void showLossMessage()
        {
            playerMoney -= playerBet;
            WinnerTextBox.Text = "-" + playerBet.ToString("C");
            // MessageBox.Show("You Lost!", "Loss!");
            CreditsTextBox.Text = playerMoney.ToString("C");
            resetFruitTally();
        }

        /* Utility function to check if a value falls within a range of bounds */
        private bool checkRange(int value, int lowerBounds, int upperBounds)
        {
            return (value >= lowerBounds && value <= upperBounds) ? true : false;
            
        }

        /* When this function is called it determines the betLine results.
    e.g. Bar - Orange - Banana */
        private string[] Reels()
        {
            string[] betLine = { " ", " ", " " };
            int[] outCome = { 0, 0, 0 };

            for (var spin = 0; spin < 3; spin++)
            {
                outCome[spin] = this.random.Next(65) + 1;



                if (checkRange(outCome[spin], 1, 27)) {  // 41.5% probability
                    betLine[spin] = "blank";
                    blanks++;
                    }
                else if (checkRange(outCome[spin], 28, 37)){ // 15.4% probability
                    betLine[spin] = "grapes";
                    grapes++;
                }
                else if (checkRange(outCome[spin], 38, 46)){ // 13.8% probability
                    betLine[spin] = "banana";
                    bananas++;
                }
                else if (checkRange(outCome[spin], 47, 54)){ // 12.3% probability
                    betLine[spin] = "orange";
                    oranges++;
                }
                else if (checkRange(outCome[spin], 55, 59)){ //  7.7% probability
                    betLine[spin] = "cherry";
                    cherries++;
                }
                else if (checkRange(outCome[spin], 60, 62)){ //  4.6% probability
                    betLine[spin] = "bar";
                    bars++;
                }
                else if (checkRange(outCome[spin], 63, 64)){ //  3.1% probability
                    betLine[spin] = "bell";
                    bells++;
                }
                else if (checkRange(outCome[spin], 65, 65)){ //  1.5% probability
                    betLine[spin] = "seven";
                    sevens++;
                }

            }
            return betLine;
        }

        /* This function calculates the player's winnings, if any */
        private void determineWinnings()
        {
            if (blanks == 0)
            {
                if (grapes == 3)
                {
                    winnings = playerBet * 10;
                }
                else if (bananas == 3)
                {
                    winnings = playerBet * 20;
                }
                else if (oranges == 3)
                {
                    winnings = playerBet * 30;
                }
                else if (cherries == 3)
                {
                    winnings = playerBet * 40;
                }
                else if (bars == 3)
                {
                    winnings = playerBet * 50;
                }
                else if (bells == 3)
                {
                    winnings = playerBet * 75;
                }
                else if (sevens == 3)
                {
                    winnings = playerBet * 100;
                }
                else if (grapes == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (bananas == 2)
                {
                    winnings = playerBet * 2;
                }
                else if (oranges == 2)
                {
                    winnings = playerBet * 3;
                }
                else if (cherries == 2)
                {
                    winnings = playerBet * 4;
                }
                else if (bars == 2)
                {
                    winnings = playerBet * 5;
                }
                else if (bells == 2)
                {
                    winnings = playerBet * 10;
                }
                else if (sevens == 2)
                {
                    winnings = playerBet * 20;
                }
                else if (sevens == 1)
                {
                    winnings = playerBet * 5;
                }
                else
                {
                    winnings = playerBet * 1;
                }
                winNumber++;
                showWinMessage();
            }
            else
            {
                lossNumber++;
                showLossMessage();
            }

        }

        private void SpinPictureBox_Click(object sender, EventArgs e)
        {
            //no longer needed playerBet = 10; // default bet amount

            if (playerMoney == 0)
            {
                if (MessageBox.Show("You ran out of Money! \nDo you want to play again?","Out of Money!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resetAll();
                    showPlayerStats();
                }
            }
            else if (playerBet > playerMoney)
            {
                MessageBox.Show("You don't have enough Money to place that bet.", "Insufficient Funds");
                SpinPictureBox.Image = Resources.spin_disabled;
            }
            else if (playerBet <= 0)
            {
                MessageBox.Show("All bets must be a positive $ amount.", "Incorrect Bet");
            }
            else if (playerBet <= playerMoney)
            {
  
                spinResult = Reels();
                //i spent 3 hours on this
                //kill me
                ResourceManager RM = Resources.ResourceManager;
                LeftWinPictureBox.Image = (Bitmap)RM.GetObject(spinResult[0]);
                MiddleWinPictureBox.Image = (Bitmap)RM.GetObject(spinResult[1]);
                RightWinPictureBox.Image = (Bitmap)RM.GetObject(spinResult[2]);


                //I think this is where I will make things look all fruity
                //this is what i did in the past
                //left
                /*
                if (spinResult[0] == "Banana")
                {
                    LeftWinPictureBox.Image = Resources.banana;
                }
                else if(spinResult[0] == "Bar")
                {
                    LeftWinPictureBox.Image = Resources.bar;
                }
                else if (spinResult[0] == "Seven")
                {
                    LeftWinPictureBox.Image = Resources.seven;
                }
                else if (spinResult[0] == "Bell")
                {
                    LeftWinPictureBox.Image = Resources.bell;
                }
                else if (spinResult[0] == "Cherry")
                {
                    LeftWinPictureBox.Image = Resources.cherry;
                }
                else if (spinResult[0] == "Grapes")
                {
                    LeftWinPictureBox.Image = Resources.grapes;
                }
                else if (spinResult[0] == "Orange")
                {
                    LeftWinPictureBox.Image = Resources.orange;
                }
                else if (spinResult[0] == "blank")
                {
                    LeftWinPictureBox.Image = Resources.blank;
                }
                //middle
                if (spinResult[1] == "banana")
                {
                    LeftWinPictureBox.Image = Resources.banana;
                }
                else if (spinResult[1] == "bar")
                {
                    LeftWinPictureBox.Image = Resources.bar;
                }
                else if (spinResult[1] == "seven")
                {
                    LeftWinPictureBox.Image = Resources.seven;
                }
                else if (spinResult[1] == "bell")
                {
                    LeftWinPictureBox.Image = Resources.bell;
                }
                else if (spinResult[1] == "cherry")
                {
                    LeftWinPictureBox.Image = Resources.cherry;
                }
                else if (spinResult[1] == "grapes")
                {
                    LeftWinPictureBox.Image = Resources.grapes;
                }
                else if (spinResult[1] == "orange")
                {
                    LeftWinPictureBox.Image = Resources.orange;
                }
                else if (spinResult[1] == "blank")
                {
                    LeftWinPictureBox.Image = Resources.blank;
                }
                //right
                if (spinResult[2] == "banana")
                {
                    LeftWinPictureBox.Image = Resources.banana;
                }
                else if (spinResult[2] == "bar")
                {
                    LeftWinPictureBox.Image = Resources.bar;
                }
                else if (spinResult[2] == "seven")
                {
                    LeftWinPictureBox.Image = Resources.seven;
                }
                else if (spinResult[2] == "bell")
                {
                    LeftWinPictureBox.Image = Resources.bell;
                }
                else if (spinResult[2] == "cherry")
                {
                    LeftWinPictureBox.Image = Resources.cherry;
                }
                else if (spinResult[2] == "grapes")
                {
                    LeftWinPictureBox.Image = Resources.grapes;
                }
                else if (spinResult[2] == "orange")
                {
                    LeftWinPictureBox.Image = Resources.orange;
                }
                else if (spinResult[2] == "blank")
                {
                    LeftWinPictureBox.Image = Resources.blank;
                }
                */

                // end fruity pictures
                fruits = spinResult[0] + " - " + spinResult[1] + " - " + spinResult[2];


               // MessageBox.Show(fruits);
                determineWinnings();
                turn++;
                SpinPictureBox.Image = Resources.spin;
                // not needed anymore showPlayerStats();
            }
            else
            {
                MessageBox.Show("Please enter a valid bet amount");
            }
        }

        private void LeftWinPictureBox_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Below this is where most of the programming for the bet buttons will go
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bet1picture_Click(object sender, EventArgs e)
        {
            //Put the money here juuust in case
            if (playerMoney > 1)
            {
                playerBet = 1;
                BetTextBox.Text = playerBet.ToString();
                SpinPictureBox.Enabled = true;
                SpinPictureBox.Image = Resources.spin;
            } else
            {
                MessageBox.Show("Sorry, but you don't have enough money for this bet!", "You're Broke!");
                SpinPictureBox.Enabled = false;
                SpinPictureBox.Image = Resources.spin_disabled;
            }
        }

        private void Bet2Picture_Click(object sender, EventArgs e)
        {
            //Put the money here juuust in case
            if (playerMoney > 2)
            {
                playerBet = 2;
                BetTextBox.Text = playerBet.ToString();
                SpinPictureBox.Enabled = true;
                SpinPictureBox.Image = Resources.spin;
            }
            else
            {
                MessageBox.Show("Sorry, but you don't have enough money for this bet!", "You're Broke!");
                SpinPictureBox.Enabled = false;
                SpinPictureBox.Image = Resources.spin_disabled;
            }
        }

        private void Bet5PictureBox_Click(object sender, EventArgs e)
        {
            //Put the money here juuust in case
            if (playerMoney > 5)
            {
                playerBet = 5;
                BetTextBox.Text = playerBet.ToString();
                SpinPictureBox.Enabled = true;
                SpinPictureBox.Image = Resources.spin;
            }
            else
            {
                MessageBox.Show("Sorry, but you don't have enough money for this bet!", "You're Broke!");
                SpinPictureBox.Enabled = false;
                SpinPictureBox.Image = Resources.spin_disabled;
            }
        }

        private void Bet10Picture_Click(object sender, EventArgs e)
        {
            //Put the money here juuust in case
            if (playerMoney > 10)
            {
                playerBet = 10;
                BetTextBox.Text = playerBet.ToString();
                SpinPictureBox.Enabled = true;
                SpinPictureBox.Image = Resources.spin;
            }
            else
            {
                MessageBox.Show("Sorry, but you don't have enough money for this bet!", "You're Broke!");
                SpinPictureBox.Enabled = false;
                SpinPictureBox.Image = Resources.spin_disabled;
            }
        }

        private void Bet25Picture_Click(object sender, EventArgs e)
        {
            //Put the money here juuust in case
            if (playerMoney > 25)
            {
                playerBet = 25;
                BetTextBox.Text = playerBet.ToString();
                SpinPictureBox.Enabled = true;
                SpinPictureBox.Image = Resources.spin;
            }
            else
            {
                MessageBox.Show("Sorry, but you don't have enough money for this bet!", "You're Broke!");
                SpinPictureBox.Enabled = false;
                SpinPictureBox.Image = Resources.spin_disabled;
            }
        }

        private void Bet50PictureBox_Click(object sender, EventArgs e)
        {
            //Put the money here juuust in case
            if (playerMoney > 50)
            {
                playerBet = 50;
                BetTextBox.Text = playerBet.ToString();
                SpinPictureBox.Enabled = true;
                SpinPictureBox.Image = Resources.spin;
            }
            else
            {
                MessageBox.Show("Sorry, but you don't have enough money for this bet!", "You're Broke!");
                SpinPictureBox.Enabled = false;
                SpinPictureBox.Image = Resources.spin_disabled;
            }
        }

        private void Bet100Picture_Click(object sender, EventArgs e)
        {
            //Put the money here juuust in case
            if (playerMoney > 100)
            {
                playerBet = 100;
                BetTextBox.Text = playerBet.ToString();
                SpinPictureBox.Enabled = true;
                SpinPictureBox.Image = Resources.spin;
            }
            else
            {
                MessageBox.Show("Sorry, but you don't have enough money for this bet!", "You're Broke!");
                SpinPictureBox.Enabled = false;
                SpinPictureBox.Image = Resources.spin_disabled;
            }
        }

        private void Bet500PictureBox_Click(object sender, EventArgs e)
        {
            //Put the money here juuust in case
            if (playerMoney > 500)
            {
                playerBet = 500;
                BetTextBox.Text = playerBet.ToString();
                SpinPictureBox.Enabled = true;
                SpinPictureBox.Image = Resources.spin;
            }
            else
            {
                MessageBox.Show("Sorry, but you don't have enough money for this bet!", "You're Broke!");
                SpinPictureBox.Enabled = false;
                SpinPictureBox.Image = Resources.spin_disabled;
            }
        }

        private void BetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuitPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "You still have money you can give us!", MessageBoxButtons.OKCancel);
           
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }
        /// <summary>
        /// Below here goes things that will change the cursor to show that you can click on the picture boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Bet1picture_MouseHover(object sender, EventArgs e)
        {
            Bet1picture.Cursor = Cursors.Hand;
        }

        private void Bet2Picture_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void Bet5PictureBox_MouseHover(object sender, EventArgs e)
        {
            Bet5PictureBox.Cursor = Cursors.Hand;
        }

        private void Bet10Picture_MouseHover(object sender, EventArgs e)
        {
            Bet10Picture.Cursor = Cursors.Hand;
        }

        private void Bet25Picture_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void Bet50PictureBox_MouseHover(object sender, EventArgs e)
        {
            Bet50PictureBox.Cursor = Cursors.Hand;
        }

        private void Bet100Picture_MouseHover(object sender, EventArgs e)
        {
            Bet100Picture.Cursor = Cursors.Hand;
        }

        private void Bet500PictureBox_MouseHover(object sender, EventArgs e)
        {
            Bet500PictureBox.Cursor = Cursors.Hand;
        }
        /// <summary>
        /// Resets the information on this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetPictureBox_Click(object sender, EventArgs e)
        {
            resetAll();
            resetFruitTally();
        }

        private void ResetPictureBox_MouseHover(object sender, EventArgs e)
        {
            ResetPictureBox.Cursor = Cursors.Hand;
        }

        private void QuitPictureBox_MouseHover(object sender, EventArgs e)
        {
            QuitPictureBox.Cursor = Cursors.Hand;
        }

        private void SpinPictureBox_MouseHover(object sender, EventArgs e)
        {
            SpinPictureBox.Cursor = Cursors.Hand;
        }
        /// <summary>
        /// Put in certain things whne it loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SlotMachineForm_Load(object sender, EventArgs e)
        {
            CreditsTextBox.Text = playerMoney.ToString("C");
            JackPotTextBox.Text = jackpot.ToString("C");
        }

        private void SpinPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            SpinPictureBox.Image = Resources.spin_pressed;
        }
    }

}
