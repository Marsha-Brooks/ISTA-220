using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double x;
            double b = 0;
            double c = 0;
            double m = 0;


            Console.WriteLine("Please give value for a: ");
            a = Convert.ToDouble(Console.ReadLine());

            x = (b + Math.Sqrt((b * b) - (4 * (a * c))) / (2 * a));

            m = ((x * x) * a) + (b * x) + c;

            Console.WriteLine(m);
            Console.WriteLine(x);
        }
    } 
}






   
    

 