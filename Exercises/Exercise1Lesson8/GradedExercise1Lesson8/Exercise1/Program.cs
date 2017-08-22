using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Exercise1
    {
        class Program
        {
            public static void Main(string[] args)
            {
                int score1, score2, score3, score4, score5, score6, score7, score8, score9, score10;
                double average;

                Console.WriteLine("Enter Your 10 Grades Below");
                score1 = GetInput("First", out score1);
                score2 = GetInput("Second", out score2);
                score3 = GetInput("Third", out score3);
                score4 = GetInput("Fourth", out score4);
                score5 = GetInput("Fifth", out score5);
                score6 = GetInput("Sixth", out score6);
                score7 = GetInput("Seventh", out score7);
                score8 = GetInput("Eight", out score8);
                score9 = GetInput("Nineth", out score9);
                score10 = GetInput("Tenth", out score10);
                average = CalcAvg(score1, score2, score3, score4, score5, score6, score7, score8, score9, score10);
                DetermineGrade(average);

            }
            public static int GetInput(string Order, out int t)
            {
                string inValue;
                Console.WriteLine("Enter the {0} test score: ", Order);
                inValue = Console.ReadLine();
                t = Convert.ToInt32(inValue);
                return t;
            }
            public static double CalcAvg(int score1, int score2, int score3, int score4, int score5, int score6, int score7, int score8, int score9, int score10)
            {
                return (score1 + score2 + score3 + score4 + score5 + score6 + score7 + score8 + score9 + score10) / 10;
            }

            public static void DetermineGrade(double avg)
            {
                char letterGrade = ' ';

                if (avg > 89)
                    letterGrade = 'A';
                else
                    if (avg > 79)
                    letterGrade = 'B';
                else
                        if (avg > 69)
                    letterGrade = 'C';
                else
                            if (avg > 59)
                    letterGrade = 'D';
                else
                                if (avg <= 59)
                    letterGrade = 'F';

                Console.WriteLine(" Your Grade is: " + letterGrade + " Your Average Score is: " + avg);
                Console.ReadKey();
            }
        }
    }
}
