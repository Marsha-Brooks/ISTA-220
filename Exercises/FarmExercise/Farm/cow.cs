using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class cow : FarmAnimals
    {
        public void eatGrass()
        {
            Console.WriteLine("I am chewing my cud");
        }
        public void gotMilk()
        {
            Console.WriteLine("I can be milked everyday");
        }
        public override void Move()
        {
            Console.WriteLine("Cows can run 20 miles per hour");
        }

    }
}

