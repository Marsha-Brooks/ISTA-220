using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumberExerciseLesson24
{
    class Bisection
    {
        public static int selectNumber = 0;
        public static Random Rand = new Random();
        public static bool GameOver = false;

        public static void Main(string[] args)
        {
            selectNumber = Rand.Next(1, 101);
            int userNumber = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 100");
                userNumber = Convert.ToInt32(Console.ReadLine());
                GuessMyNumber(userNumber);

            }
            while (GameOver == false);
            {
                Console.ReadLine();

            }
        }
            public static void GuessMyNumber(int userNumber)
            {
                int playAgian = 0;
                if (userNumber < selectNumber)
                {
                    Console.WriteLine("Too low, Try Agian");
                }
                else if (userNumber > selectNumber)
                {
                    Console.WriteLine("To high, Try Agian");
                }
                else
                {
                    Console.WriteLine("You Got It! Press 1 to Play Agian or 2 to Quit");
                    playAgian = Convert.ToInt32(Console.ReadLine());
                    while (playAgian != 1 && playAgian != 2)
                    {
                        Console.WriteLine("Please select a correct response, choose 1 to PlayAgian or 2 to quit");
                    }
                    if (playAgian == 2)

                        GameOver = true;

                    else

                        selectNumber = Rand.Next(1, 101);

                }
            }

        }
    }

