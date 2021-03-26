using System;

namespace VideogameFight.cs
{
    class Battle
    {
       
        public static void StartFight(sFighter sFighter1,
            sFighter sFighter2)
        {
          
            while (true)
            {
                if (GetAttackResult(sFighter1, sFighter2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(sFighter2, sFighter1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

       
        public static string GetAttackResult(sFighter sFighterA,
            sFighter sFighterB)
        {
          
            double warAAttkAmt = sFighterA.Attack();
            double warBBlkAmt = sFighterB.Block();

           
            double dmg2WarB = warAAttkAmt - warBBlkAmt;

            
            if (dmg2WarB > 0)
            {
                sFighterB.Health = sFighterB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                sFighterA.Name,
                sFighterB.Name,
                dmg2WarB);

            Console.WriteLine("{0} Has {1} Health\n",
                sFighterB.Name,
                sFighterB.Health);

       
            if (sFighterB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious\n",
                    sFighterB.Name,
                    sFighterA.Name);

                return "Game Over";
            }
            else return "Fight Again";
        }

    }
}
