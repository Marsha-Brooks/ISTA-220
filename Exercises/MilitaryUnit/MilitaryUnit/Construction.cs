using MilitaryUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Construction: Engineers
    {
        public void HorizVert()
        {
            Console.WriteLine("We push it down or build it up!");
        }

        public void ConstEquip()
        {
            Console.WriteLine("Dozers, Rollers, FrontLoaders and TNT, Big Toys!");
        }

        public override void Mission()
        {
            Console.WriteLine("Make a way for support elements to get through and build up footprint for operations");
        }
        

    }
    }


