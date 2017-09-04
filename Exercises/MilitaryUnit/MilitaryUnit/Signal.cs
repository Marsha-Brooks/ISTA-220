using MilitaryUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Signal : Engineers
    
        {
            public void AppendixH()
            {
                Console.WriteLine("Who are we talking to and how?");
            }

            public void CommoShop()
            {
                Console.WriteLine("Accountable for all secure and nosecure commo equip");
            }

            public override void Mission()
            {
                Console.WriteLine("Deploy redundant forms of communication across virtual battle field");
            }
        
    }
    }




