using MilitaryUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Maint : Engineers
    {
        public void CmdMaint()
        {
            Console.WriteLine("Conducted first day of each week on all equip");
        }

        public void Motorpool()
        {
            Console.WriteLine("Accountable for maintenace bays and all issued tools ");
        }

        public override void Mission()
        {
            Console.WriteLine("Maintenance checks and services");
        }
        


    }
}
