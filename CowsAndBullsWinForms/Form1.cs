using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CowsAndBullsWinForms
{
    public partial class frmCowsAndBullsGame : Form
    {
        /*
         * This project was the first major and completed WinForms project completed.
         * It uses random number generators, timers (not used before), multiple arrays, a list on the form (not used before), repeated digits in a number checker (self made) (adjustable for any size number),
         * progress bar (not used before, drop down boxes (not used before).
         * The repeated digits number checker are featured in this program, with many hours spent on understanding for loops and if loops when combined.
         * The cow checker follows a similar concept to the repeated digits number checker.
         * 
         * Remember to use a table to work out all the possible results the program will output if stuck on a problem!
        */

        static int i;
        static int j;

        static int[] randomNumberDigits = new int[4];                   //Random number segment
        static int randomNumberInt;
        static string randomNumberString;
        static Random generator = new Random();

        private System.Windows.Forms.Timer exitTimer;                   //Timer segment
        private int countdownTime = 5;

        static int[] userNumberDigits = new int[4];                 //User number segment
        static int userGuessNumberInt;

        static int cowCounter;                  //Counter segment
        static int bullCounter;
        static int triesCounter = 0;

        static bool listAdd = true;
        static bool repeatedDigit = false;

        public frmCowsAndBullsGame()
        {
            InitializeComponent();
        }

        private void frmCowsAndBullsGame_Load(object sender, EventArgs e)
        {
            timeUntilExit.Minimum = 0;
            timeUntilExit.Maximum = 5;
            timeUntilExit.Value = 0;
        }

        static void random()                    //Random number generator and checker
        {
            randomNumberInt = generator.Next(1234, 9877);                   //First is inclusive and second is exclusive
            randomNumberString = randomNumberInt.ToString();

            for (i = 0; i <= 2; i++)                    //Checker for if there are repeating digits in the random number, if there is a new number is generated
            {
                j = i + 1;
                do
                {
                    if (randomNumberString.Substring(i, 1) == randomNumberString.Substring(j, 1))
                    {
                        random();
                    }
                    j++;
                }
                while (j <= 3);
            }

            randomNumberDigits[0] = int.Parse(randomNumberString.Substring(0, 1));
            randomNumberDigits[1] = int.Parse(randomNumberString.Substring(1, 1));
            randomNumberDigits[2] = int.Parse(randomNumberString.Substring(2, 1));
            randomNumberDigits[3] = int.Parse(randomNumberString.Substring(3, 1));
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            try
            {
                cmdExit.Enabled = false;

                exitTimer = new System.Windows.Forms.Timer();
                exitTimer.Tick += new EventHandler(exitTimer_Tick);
                exitTimer.Interval = 5000;                  // 5 seconds, number is in milliseconds
                exitTimer.Start();
                progressBarTimer.Enabled = true;
                lblRandomNumber.Text = "[" + randomNumberString.Substring(0, 1) + "] " + "[" + randomNumberString.Substring(1, 1) + "] " + "[" + randomNumberString.Substring(2, 1) + "] " + "[" + randomNumberString.Substring(3, 1) + "]";
            }
            catch
            {
                Application.Exit();
            }
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            if (timeUntilExit.Value != 5)
            {
                timeUntilExit.Value++;
            }
        }

        private void exitTimer_Tick(object sender, EventArgs e)
        {
            countdownTime--;
            if (countdownTime != 0)
            {
                exitTimer.Stop();
                Application.Exit();
            }
        }

        private void cmdTutorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I have generated a 4 digit number with no repeating digits." + Environment.NewLine + Environment.NewLine +
                            "You will enter a 4 digit number into the drop down boxes." + Environment.NewLine + Environment.NewLine +
                            "If one of the digits in your number is also present in my number, I will add a cow." + Environment.NewLine +
                            "If one of the digits in your number is in the same place as my number, I will add a bull." + Environment.NewLine + Environment.NewLine +
                            "If you get 4 bulls in one guess, this means that both of our numbers are exactly the same and you win the game!");
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            cmdStart.Enabled = false;
            cmdGuess.Enabled = true;
            lstGuessList.Items.Clear();
            random();

            //lblRandomNumber.Text = randomNumberString;         //Testing
        }

        private void userInput()                    //Saves the user input number into a array and checks if its too big or small
        {
            try
            {
                userNumberDigits[0] = int.Parse(cmbUserNumberA.Text.ToString());
                userNumberDigits[1] = int.Parse(cmbUserNumberB.Text.ToString());
                userNumberDigits[2] = int.Parse(cmbUserNumberC.Text.ToString());
                userNumberDigits[3] = int.Parse(cmbUserNumberD.Text.ToString());

                userGuessNumberInt = (userNumberDigits[0] * 1000) + (userNumberDigits[1] * 100) + (userNumberDigits[2] * 10) + userNumberDigits[3];

                //MessageBox.Show("The second digit is " + userNumberDigits[1]);                  //Testing

                if (userGuessNumberInt < 1023 || userGuessNumberInt > 9876)
                {
                    MessageBox.Show("The value you have inserted is not valid. \n Please try again!");
                    listAdd = false;
                }
                else if (userNumberDigits[0] > 9 || userNumberDigits[1] > 9 || userNumberDigits[2] > 9 || userNumberDigits[3] > 9 || userNumberDigits[0] < 0 || userNumberDigits[1] < 0 || userNumberDigits[2] < 0 || userNumberDigits[3] < 0)
                {
                    MessageBox.Show("The value you have inserted is not valid. \n Please try again!");
                    listAdd = false;
                }
            }
            catch
            {
                MessageBox.Show("The value you have inserted is not valid. \n Please try again!");
                listAdd = false;
            }
        }

        private void numberComparison()                 //Checks between the random and user number to find bulls
        {
            if (userGuessNumberInt == randomNumberInt)
            {
                cmdGuess.Enabled = false;
                MessageBox.Show("You have won the game! Your number is the same as the randomly generated one! \n You took " + triesCounter + " try to win!");
                cmdStart.Enabled = true;
                triesCounter = 0;
            }
            else
            {
                i = 0;

                for (int i = 0; i <= 3; i++)
                {
                    if (userNumberDigits[i] == int.Parse(randomNumberString.Substring(i, 1)))
                    {
                        bullCounter++;
                    }
                }

                cowComparer();
            }
        }

        private void cowComparer()                  //Checks between the random and user number to find cows
        {
            i = 0;
            j = 0;

            for (int j = 0; j < 4; j++)
            {
                //MessageBox.Show("The value of j is " + j);                    //Testing

                for (int i = 0; i < 4; i++)
                {
                    //MessageBox.Show("The value of i is " + i);                    //Testing

                    if (randomNumberDigits[j] == userNumberDigits[i])
                    {
                        cowCounter++;
                        //MessageBox.Show("The amount of cows is " + cowCounter);                   //Testing
                    }
                }
            }
        }

        private void repeatedDigits()
        {
            for (i = 0; i <= 2; i++)
            {
                j = i + 1;

                //MessageBox.Show(userGuessNumberInt + " " + i + " " + j);                 //Testing

                do
                {
                    if (userNumberDigits[i] == userNumberDigits[j])
                    {
                        repeatedDigit = true;
                        listAdd = false;

                        if (triesCounter != 0)
                        {
                            triesCounter--;
                        }
                    }
                    j++;
                }
                while (j <= 3);
            }
        }

        private void cmdGuess_Click(object sender, EventArgs e)
        {
            i = 0;
            j = i + 1;
            triesCounter++;
            bullCounter = 0;
            cowCounter = 0;
            listAdd = true;

            userInput();

            //MessageBox.Show(userGuessNumberInt + " " + i + " " + j);                 //Testing

            repeatedDigits();

            if (repeatedDigit == true)
            {
                MessageBox.Show("A repeated digit is present in your number, please try again!");
                repeatedDigit = false;
            }

            if (listAdd == true)
            {
                numberComparison();
                lblBullsAmount.Text = "The amount of bulls is: " + bullCounter;
                lblCowsAmount.Text = "The amount of cows is: " + cowCounter;
                lstGuessList.Items.Add(userGuessNumberInt);
            }
        }
    }
}