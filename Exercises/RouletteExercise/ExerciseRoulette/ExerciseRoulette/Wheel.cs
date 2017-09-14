using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseRoulette
{
    class Wheel
    {
        public int[] Pockets;
        public int[] z;
        public int[] dz;
        public int[] red;
        public int[] black;
        public Random Spin;
        public int bet;
        public int ball;
        public string [] Basket;
        public string balldrop;
    


        public Wheel()
        {
            this.Pockets = new int[36]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32,
            33, 34, 35, 36};
            this.z = new int[0];
            this.dz = new int[100];
            this.red = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            this.black = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            this.Spin = new Random();
            this.bet = 0;
            this.ball = 0;
            int randomIndex = Spin.Next(0, 36);
            int randomNumber = Pockets[randomIndex];
            int randomEnum = Spin.Next();  
            Basket = new String [38]{"zero", "doubleZero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten","eleven","twelve", "thirteen",
            "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty", "twentyone", "twentytwo", "twentythree", "twentyfour", "twentyfive",
            "twentysix", "twentyseven", "twentyeight", "twentynine", "thirty", "thirtyone", "thirtytwo", "thirtythree", "thirtyfour", "thirtyfive", "thirtysix"};
            this.balldrop = "";
        }
    public void SpinWheel()
        {
            Console.WriteLine("Choose Your Bet From Options Listed" + "1. Straight, 2. Split, 3. Basket," +
                " 4. Street, 5. Corner, 6. SixLine, 7. 1st Column, 8. 2nd Column, 9. 3rd Column, 10. 1st Dozen" +
                "11. 2nd Dozen, 12. 3rd Dozen, 13. Odds, 14. Evens, 15. Reds, 16. Blacks, 17. Lows, 18. Highs:  " );
        Console.ReadLine();
        this.bet = Convert.ToInt32(Console.ReadLine());
           


        }
        public void PlayStraight(int bet, int ball)
        {
            Console.WriteLine("Select a number between 1 and 36: ");
            this.bet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen number {bet}" + "Good Luck!" + "The Wheel is Spinning!");
            this.ball = Spin.Next(0, Pockets.Length);
            Console.WriteLine("The Wheel Spun a {ball}");

            if (bet == ball)
            {
                Console.WriteLine("Congratulations You Are a Winner!");
            }
            else
            {
                Console.WriteLine("I'm Sorry You Lost!");

               
            }

        public void PlayBasket( string balldrop)
            {
                Console.WriteLine("You have chosen a Basket Bet, your bet includes 0,00,1,2,3" + "Good Luck" + "The Wheel is Spinning");
                this.balldrop = Basket[new Random().Next(0, Basket.Length)];
                Console.WriteLine("The Wheel Spun a {balldrop}");

                if (balldrop == "zero")
                {
                    Console.WriteLine("Congratulations You are a Winner!");
                }
                else if (balldrop == "doubleZero")
                {
                    Console.WriteLine("Congratulations You are a Winner!");
                }
                else if (balldrop == "one")
                {
                    Console.WriteLine("Congratulations You are a Winner!");
                }
                else if (balldrop == "two")
                {
                    Console.WriteLine("Congratulations You are a Winner!");
                }
                else if (balldrop == "three")
                {
                    Console.WriteLine("Congratulations You are a Winner!");
                }
                else
                {
                    Console.WriteLine("Sorry You Lost!");
                }
            }
            public void PlayStreet(int bet, int ball)
            {
                Console.WriteLine("You have chosen a Street Bet, please select the number at the beginning of your row: ");
                    this.bet = Convert.ToInt32(Console.ReadLine());
                if (bet == 1)
                {
                    Console.WriteLine("You have selected the row beginning with the number 1, your numbers include 1,2,3" + "Good Luck" +
                        "The Wheel is Spinning");

                }
                else if (bet == 4)
                {
                    Console.WriteLine("You have selected the row beginning with the number 4, your numbers include 4,5,6" + "Good Luck" +
                           "The Wheel is Spinning");

                }
                else if (bet == 7) 
                {
                    Console.WriteLine("You have selected the row beginning with the number 7, your numbers include 7,8,9" + "Good Luck" +
                        "The Wheel is Spinning");
                }
                else if(bet == 10)
                {
                    Console.WriteLine("You have selected the row beginning with the number 10, your numbers include 10,11,12" + "Good Luck" +
                                            "The Wheel is Spinning");
                }
                else if (bet == 13)
                {
                    Console.WriteLine("You have selected the row beginning with the number 13, your numbers include 13,14,15" + "Good Luck" +
                        "The Wheel is Spinning");
                }
                else if (bet == 16 )
                {
                    Console.WriteLine("You have selected the row beginning with the number 16, your numbers include 16,17,18" + "Good Luck" +
                        "The Wheel is Spinning");
                }
                else if (bet == 19 )
                {
                    Console.WriteLine("You have selected the row beginning with the number 19, your numbers include 19,20,21" + "Good Luck" +
                        "The Wheel is Spinning");

                }
                else if(bet == 22)
                {
                    Console.WriteLine("You have selected the row beginning with the number 22, your numbers include 22,23,4" + "Good Luck" +
                        "The Wheel is Spinning");
                }
                    else if(bet == 25)
                {
                    Console.WriteLine("You have selected the row beginning with the number 25, your numbers include 25,26,27" + "Good Luck" +
                        "The Wheel is Spinning");
                }
                    else if(bet == 28 )
                {
                    Console.WriteLine("You have selected the row beginning with the number 28, your numbers include 28,29,30" + "Good Luck" +
                        "The Wheel is Spinning");
                }
                    else if (bet == 31)
                {
                    Console.WriteLine("You have selected the row beginning with the number 31, your numbers include 31,32,33" + "Good Luck" +
                                            "The Wheel is Spinning");
                }
                    else if(bet == 34)
                {
                    Console.WriteLine("You have selected the row beginning with the number 34, your numbers include 34,35,36" + "Good Luck" +
                        "The Wheel is Spinning");
                }
                else
                {
                    Console.WriteLine("You did not choose a number that is at the beginning of a row, please try agian");
                }
            
                
        private void Spin_Wheel(object sender, RoutedEventArgs e)
        {


        }


    }
}
