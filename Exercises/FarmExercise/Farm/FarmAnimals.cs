using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class FarmAnimals
    {
        public void animalSays(string noiseToMakeWhenSaying)
        {
            Console.WriteLine($"Animal Says: {noiseToMakeWhenSaying}");

        }
        public virtual void Move()
        {
            Console.WriteLine("Implement default of the Move method");
        }
    }
}

