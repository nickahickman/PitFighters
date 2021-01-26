using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    public static class BuildParty
    {
        public static List<Fighter> BuildFighterParty(int count)
        {
            List<Fighter> fighters = new List<Fighter>();

            for (int i = 1; i <= count; i++)
            {
                string name = GetFighterName(i);
                fighters.Add(new Fighter(name));
            }

            return fighters;
        }

        public static string GetFighterName(int fighterNumber)
        {
            string fighterName = "fighter";

            Console.Clear();
            Console.WriteLine($"What is fighter {fighterNumber}'s name");
            fighterName = Console.ReadLine();

            return fighterName;
        }
    }
}
