using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void farmWork()
        {
            Console.WriteLine("A Waddle with a Duck");
            duck myduck = new duck();
            myduck.animalSays("Quack Quack");
            myduck.eatGrain();
            myduck.findWater();
            myduck.Move();

           Console.WriteLine("A Wallow with a Pig");
            pig mypig = new pig();
            mypig.animalSays("Oink Oink");
            mypig.eatSlop();
            mypig.mudRoll();
            mypig.Move();

            Console.WriteLine("A Gallop with a Horse");
            Horse myhorse = new Horse();
            myhorse.animalSays("Neigh, Neigh");
            myhorse.eatHay();
            myhorse.saddleFit();
            myhorse.Move();

            Console.WriteLine("A Stroll with a Cow");
            cow mycow = new cow();
            mycow.animalSays("Moooooooooo!");
            mycow.eatGrass();
            mycow.gotMilk();
            mycow.Move();

            Console.WriteLine("A Talk with a Goat");
            goat mygoat = new goat();
            mygoat.animalSays("Baaaaaa, Baaaa");
            mygoat.eatFeed();
            mygoat.climbRocks();
            mygoat.Move();
            }

    static void Main()
    {
        try
        {
            farmWork();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: {0}", ex.Message);
        }
    }
}
}
