using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class goat : FarmAnimals
    {
        public void eatFeed()
        {
            Console.WriteLine("I will eat just about anything");
        }
        public void climbRocks()
        {
            Console.WriteLine("I am a great climber");
        }

        public override void Move()
        {
            Console.WriteLine("I can run 15 miles per hour");
        }
    }
}

