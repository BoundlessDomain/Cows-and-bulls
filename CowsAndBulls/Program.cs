using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    class Program
    {
        static int randomNumber;
        static Random generator = new Random();

        static int numberTheyPicked;
        static string numberTheyPickedString;
        static string tutorialOrNot;
        static bool takeAGuess = false;

        static int theirNumberOne;
        static int theirNumberTwo;
        static int theirNumberThree;
        static int theirNumberFour;

        static int counterA = 0;
        static int counterB = 1;

        static void random()
        {
            randomNumber = generator.Next(1000, 10000);  //First is inclusive and second is exclusive
        }


        static void tutorial()
        {
            if (tutorialOrNot == "Yes")
             { 
                Console.WriteLine();
                Console.WriteLine("The game is simple, I generate a 4 digit number with no repeates,");
                Console.WriteLine("You eneter a 4 digit number with no repeates,");
                Console.WriteLine("Every digit is compared to each other between our numbers,");
                Console.WriteLine("If one of your digits is the same as mine in the same place,");
                Console.WriteLine("I say bull,");
                Console.WriteLine("If one of your digits is the same as mine but in a different place,");
                Console.WriteLine("I say cow.");
                Console.WriteLine("You win the game when you get the same number as me!");
                Console.WriteLine("Good luck!!");

                Console.ReadLine();

                tutorialOrNot = "Start";
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to read the tutorial?");
            Console.WriteLine("Press Y to continue tutorial or N to begin the game!");
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                tutorialOrNot = "Yes";
                tutorial();
                
            }
            else
            {
                tutorialOrNot = "Start";
            }

            while (tutorialOrNot == "Start")
            {
                Console.WriteLine();

                Console.WriteLine(randomNumber);

                Console.WriteLine("Please enter a 4 digit number that you want to pick:");
                numberTheyPicked = int.Parse(Console.ReadLine());
                numberTheyPickedString = Console.ReadLine();
                
                try
                {
                    do
                    {
                        do
                        {
                            if (numberTheyPickedString.Substring(counterA,1) == numberTheyPickedString.Substring(counterB,1))
                            {
                                Console.WriteLine("Your number contains repeated digits!");
                                Console.ReadLine();
                                throw new Exception();
                            }
                            counterB++;
                        } while (counterB <= numberTheyPickedString.Length);
                        counterA++;
                        counterB = 2;

                        do
                        {
                            if (numberTheyPickedString.Substring(counterA, 1) == numberTheyPickedString.Substring(counterB, 1))
                            {
                                Console.WriteLine("Your number contains repeated digits!");
                                Console.ReadLine();
                                throw new Exception();
                            }
                            counterB++;
                        } while (counterB <= numberTheyPickedString.Length);
                        counterA++;
                        counterB = 3;

                        do
                        {
                            if (numberTheyPickedString.Substring(counterA, 1) == numberTheyPickedString.Substring(counterB, 1))
                            {
                                Console.WriteLine("Your number contains repeated digits!");
                                Console.ReadLine();
                                throw new Exception();
                            }
                            counterB++;
                        } while (counterB <= numberTheyPickedString.Length);
                        counterA++;
                        counterB = 4;



                        if (numberTheyPicked < 1000)
                        {
                            Console.WriteLine("The number you entered is not 4 digits!");
                            takeAGuess = false;
                        }
                        else
                        if (numberTheyPicked > 9999)
                        {
                            Console.WriteLine("The numebr you entered is not 4 digits!");
                            takeAGuess = false;
                        }
                        else
                        if (takeAGuess == true)
                        {
                            Console.WriteLine("Tempoary text");  //Whole game goes here
                            Console.ReadLine();
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    while (takeAGuess == false);
                }
                catch
                {
                    Console.WriteLine("Your input is invalid!");
                    Console.ReadLine();
                }
             }
        }
    }
}
