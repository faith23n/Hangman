using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4_Anderson_Nicole
{
    public partial class Form1 : Form
    {
        int myGuess; // User input
        int number;
        int count = 1; // Counts the trys the user does
        
        public Form1()
        {
            InitializeComponent();
            AcceptButton = testButton;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();

            number = rand.Next(101);
        }

        private void testButton_Click(object sender, EventArgs e)
        {

            // myGuess represents the number entered by the user
            myGuess = int.Parse(guessBox.Text);
            
            // This statement first tests that the number entered is between 1 and 100
            if ((myGuess < 0) || (myGuess > 101))
            {   
                errorMessage.Text = " You did not enter a number between 1 and 100.";    
            }
            else
            {
                errorMessage.Text = "";
                count++;
                    // use count of trys as a switch
                    switch (count)
                    {
                        case 1: 
                            if (number == myGuess)
                            {
                                testButton.Enabled = false;
                                newGameBox.Visible = true;

                                errorMessage.Text = " You Won!!! ";

                                pictureBox.Image = Properties.Resources.yay;

                        }
                            else if (number < myGuess)
                            {
                                errorMessage.Text = " Nope. Answer is less than " + myGuess;
                                guessBox.Clear();
                                pictureBox.Image = Properties.Resources.hangman01;
                            }
                            else
                            {
                                errorMessage.Text = " Nope. Answer is greater than " + myGuess;
                                guessBox.Clear();
                                pictureBox.Image = Properties.Resources.hangman01;
                            }
                            break;
                        case 2:
                            if (number == myGuess)
                            {
                                testButton.Enabled = false;
                                newGameBox.Visible = true;

                                errorMessage.Text = " You Won!!! ";

                                pictureBox.Image = Properties.Resources.yay;
                            }
                            else if (number < myGuess)
                            {
                                errorMessage.Text = " Nope. Answer is less than " + myGuess;
                            guessBox.Clear();
                            pictureBox.Image = Properties.Resources.hangman01;
                            }
                            else
                            {
                                errorMessage.Text = " Nope. Answer is greater than " + myGuess;
                            guessBox.Clear();
                            pictureBox.Image = Properties.Resources.hangman01;
                            }
                            break;
                        case 3:
                            if (number == myGuess)
                            {
                                testButton.Enabled = false;
                                newGameBox.Visible = true;

                                errorMessage.Text = " You Won!!! ";

                                pictureBox.Image = Properties.Resources.yay;
                            }
                            else if (number < myGuess)
                            {
                                errorMessage.Text = " Nope. Answer is less than " + myGuess;
                            guessBox.Clear();
                            pictureBox.Image = Properties.Resources.hangman02;
                            }
                            else
                            {
                                errorMessage.Text = " Nope. Answer is greater than " + myGuess;
                            guessBox.Clear();
                            pictureBox.Image = Properties.Resources.hangman02;  
                            }
                            break;

                        case 4:
                            if (number == myGuess)
                            {
                                testButton.Enabled = false;
                                newGameBox.Visible = true;

                                errorMessage.Text = " You Won!!! ";

                                pictureBox.Image = Properties.Resources.yay;
                        }
                            else if (number < myGuess)
                            {
                                errorMessage.Text = " Nope. Answer is less than " + myGuess;
                                guessBox.Clear();
                                pictureBox.Image = Properties.Resources.hangman05;
                            }
                            else
                            {
                                errorMessage.Text = " Nope. Answer is greater than " + myGuess;
                                guessBox.Clear();
                                pictureBox.Image = Properties.Resources.hangman05;
                            }
                            break;
                        case 5:
                            if (number == myGuess)
                            {
                                testButton.Enabled = false;
                                newGameBox.Visible = true;

                                errorMessage.Text = " You Won!!! ";

                                pictureBox.Image = Properties.Resources.yay;
                            }
                            else if (number < myGuess)
                            {
                                errorMessage.Text = " Nope. Answer is less than " + myGuess;
                                guessBox.Clear();
                                pictureBox.Image = Properties.Resources.hangman06;
                            }
                            else
                            {
                                errorMessage.Text = " Nope. Answer is greater than " + myGuess;
                                guessBox.Clear();
                                pictureBox.Image = Properties.Resources.hangman06;
                            }
                            break;
                        case 6:
                            if (number == myGuess)
                            {
                                testButton.Enabled = false;
                                newGameBox.Visible = true;

                                errorMessage.Text = " You Won!!! ";

                                pictureBox.Image = Properties.Resources.yay;
                            }
                            else if (number < myGuess)
                            {
                                errorMessage.Text = " Nope. Answer is less than " + myGuess;
                                guessBox.Clear();
                                pictureBox.Image = Properties.Resources.hangman07;
                            }
                            else
                            {
                                errorMessage.Text = " Nope. Answer is greater than " + myGuess;
                                guessBox.Clear();
                                pictureBox.Image = Properties.Resources.hangman07;
                            }
                            break;
                        case 7:
                            if (number == myGuess)
                            {
                                testButton.Enabled = false;
                                newGameBox.Visible = true;

                                errorMessage.Text = " You Won!!! ";

                                pictureBox.Image = Properties.Resources.yay;
                            }
                            else
                            {
                                testButton.Enabled = false;
                                newGameBox.Visible = true;

                                errorMessage.Text = " You Lose. The answer was " + number;

                                pictureBox.Image = Properties.Resources.dead;
                            }
                            break;
                        default:
                        testButton.Enabled = false;
                        errorMessage.Text = " Sorry! You only get 6 tries! ";
                            break;
                  
                }
            }
            
        }
      
        private void guessBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newGameBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void yesButton_CheckedChanged(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void noButton_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
