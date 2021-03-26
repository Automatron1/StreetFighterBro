using System;

namespace VideogameFight.cs
{
    class Program
    {
        

        static void Main(string[] args)
        {
            sFighter chunli = new sFighter("Chun-Li", 1000, 120, 40);
            sFighter guile = new sFighter("Guile", 1000, 120, 40);

            Battle.StartFight(chunli, guile);

            Console.ReadLine();

        }

    }

}