using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberLesson24Pt2
{
    class Program
    {
        public static int selectNumber = 0;
        public static Random Rand = new Random();
        public static bool GameOver = false;
        public static int userInput = 0;
        public static string guess = "";
        public static int x0 = 0;
        public static int x1 = 100;
        public static int x2 = 50;
        public static int count = 1;
        public static string guesses = "";

        public static void Main(string[] args)
        {
            
            Console.WriteLine("Guess a number between 1 and 100 shhh don't tell me, let me guess.");


            do
            {
                selectNumber = Rand.Next(x0, x1);
                guess = selectNumber + "";
                Console.WriteLine("Computer guesses" + " " + guess + '\n' + "If this is Correct: press 1" + 
                    '\n' + "If the guess is too High: press 2" + '\n' + 
                   "If the guess is too Low: press 3");

                userInput = Convert.ToInt32(Console.ReadLine());
                count = count + 1;
                guesses = count + "";
             


                
                

                GuessYourNumber(userInput);
             
                    

            }
            while (GameOver == false);
            {
                Console.ReadLine();

            }
        }
        public static void GuessYourNumber(int userInput)

        {
            int playAgian = 0;

            if (userInput == 2)
            {
                x2 = selectNumber;
                x1 = x2;
                selectNumber = Rand.Next(x0, x1);
                Console.WriteLine("Dang it! I will have to guess for the" + " " + guesses + " " + " time because you said:");
                Console.WriteLine("I guessed too High!");
            }
            else if (userInput == 3)
            {
                x2 = selectNumber;
                x0 = x2;
                selectNumber = Rand.Next(x0, x1);
                Console.WriteLine("Dang it! I will have to guess for the" + " " + guesses + " " + " time because you said:");
                Console.WriteLine("I guessed to Low!");


            }
            else
            
            {
                Console.WriteLine("I got it right?! Awesome Sauce!"  + '\n' + "If you want to play agian Press:  4" + '\n'+ "If you want to quit Press: 5");
                playAgian = Convert.ToInt32(Console.ReadLine());
               
                if (playAgian == 5)
                {
                    GameOver = true;
                }
                else if (playAgian == 4 )
                {
                    Console.WriteLine("Guess a number between 1 and 100 shhh don't tell me");
                }
            }
        }
            



            }
        }

    


