using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        public void sumAverageElements(int[] arr, int size)
            {
                int sum = 0;
                int average = 0;
                for (int i = 0; i<size; i++) 
                {
                    sum += arr[i];
                }
    average = sum / size;
            DetermineGrade(average);

    Console.ReadLine();
}
public static void Main(String[] args)
{
                int size;
    Console.WriteLine("Enter the total number of your scores :");
    size = Convert.ToInt32(Console.ReadLine());
                int[]
    a = new int[size]; 
                for (int i = 0; i<size; i++)
                {
    a[i] = Convert.ToInt32(Console.ReadLine()); 
                }
int len = a.Length;
            Program pg = new Program();
pg.sumAverageElements(a, len);
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

                Console.WriteLine(" Your Average Letter Grade is: " + letterGrade +  " Your Average Score is: "  + avg);
                Console.ReadKey();
            }
        }
    }

