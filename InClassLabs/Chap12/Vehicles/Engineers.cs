using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit 
{
    class Engineers
    {

        public void HeadCount(string rosterofallpersonnel)
        {
            Console.WriteLine($"HeadCount: {rosterofallpersonnel}");
        }

        public void CombatPower(string countandstatusofvehiclesandequipment)
        {
            Console.WriteLine($"CombatPower: {countandstatusofvehiclesandequipment}");
        }

        public virtual void Mission()
        {
            Console.WriteLine("Default implementation of Mission");
        }
        public void Report(int Perstat)
        { 

            Perstat = 0;
            
            Console.ReadLine();
            Console.WriteLine("Report your Head Count now");
             Perstat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your headcount is (P1)");
            
        }
    }
}
