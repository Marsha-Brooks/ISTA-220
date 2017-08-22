using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        public static void Main(String[] args)
        {
            string number;
            double total = 0;
            int numbers = 0;
            double average;
            Console.WriteLine("Enter all of your Test scores, hit enter twice when complete");
            while ((number = Console.ReadLine()) != "")
            {
                total += double.Parse(number);
                numbers++;
            }
            Console.WriteLine("The average of the numbers entered is {0}", total / numbers);
            average = total / numbers;
            DetermineGrade(average);
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

            Console.WriteLine(" Your Average Letter Grade is: " + letterGrade + " Your Average Score is: " + avg);
            Console.ReadKey();
        }
    }
}

