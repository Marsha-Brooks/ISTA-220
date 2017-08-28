using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class pig : FarmAnimals
    {
        public void eatSlop()
        {
            Console.WriteLine("I love to get food all over my face");
        }
        public void mudRoll()
        {
            Console.WriteLine("When I poop, I poop in in mud and lay in it!");
        }
        public override void Move()
        {
            Console.WriteLine("Pigs can run 11 miles per hour");
        }
    }
}
