using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    public static class BuildParty
    {
        public static List<Fighter> BuildFighterParty(int playerNumber, int count)
        {
            List<Fighter> fighters = new List<Fighter>();

            for (int i = 1; i <= count; i++)
            {
                Console.Clear();
                Console.WriteLine($"Player {playerNumber}'s party");
                Console.WriteLine($"---------------------------");

                string name = GetFighterName(i);
                fighters.Add(new Fighter(name));
            }

            return fighters;
        }

        public static string GetFighterName(int fighterNumber)
        {
            string fighterName = "fighter";

            Console.WriteLine($"What is fighter {fighterNumber}'s name");
            fighterName = Console.ReadLine();

            return fighterName;
        }
    }
}
