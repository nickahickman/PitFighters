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

            for (int i = 0; i < count; i++)
            {
                Console.Clear();
                Console.WriteLine($"Player {playerNumber}'s party");
                Console.WriteLine($"---------------------------");

                string name = UserInput.GetStringResponse($"What is fighter {i + 1}'s name? ");
                fighters.Add(new Fighter(name));
            }

            return fighters;
        }
    }
}
