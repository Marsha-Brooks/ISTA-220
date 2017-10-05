using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CircumfranceandAreaOfCircle
{
    class Program
    {
        static void Main()
        // Perimeter (Circumference) of a circle: C=2πr
        {
            int r;
           r = Convert.ToInt32(Console.ReadLine());
            double radius;
            radius = double.Parse(Console.ReadLine());
            double pi;
            pi = Math.PI;
            double area;
            area = 2 * pi * r;

            Console.WriteLine("Please write the radius of your circle and hit Enter afterwards: ");
            Console.WriteLine("The Perimeter or Circumference (C=2πr) of your circle is: {0:F2}", area);
            Console.WriteLine("The Area of the Circle is {A}");
        }
    }
}


            
        
    



