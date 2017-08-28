using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Horse : FarmAnimals
    {
        public void eatHay()
        {
            Console.WriteLine("I love my hay and my brownsugar pellets");
        }
        public void saddleFit()
        {
            Console.WriteLine("I can wear several different kinds of Saddles");
        }
        public override void Move()
        {
            Console.WriteLine("Horses can run 30 miles per hour");
        }
    }
}
