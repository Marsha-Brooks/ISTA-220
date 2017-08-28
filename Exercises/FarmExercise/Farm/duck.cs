using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class duck : FarmAnimals
    {
        public void eatGrain()
        {
            Console.WriteLine("The farmer feeds me grain");
        }
        public void findWater()
        {
            Console.WriteLine("I spend most of my time in water");
        }

        public override void Move()
        {
            Console.WriteLine("I can't run fast, but I can fly over 40 miles per hour");
        }
    }
}


