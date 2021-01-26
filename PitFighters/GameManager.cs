using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    class GameManager
    {
        public void Run()
        {
            Console.WriteLine(WelcomeMessage());

            while (true)
            {
                int partySize = GetPartySize();
                List<Fighter> playerOneFighters = BuildParty.BuildFighterParty(partySize);
            }
        }

        public string WelcomeMessage()
        {
            return $"Welcome to pit fighters";
        }

        public int GetPartySize()
        {
            int partySize = 0;

            Console.WriteLine("How many fighters will each party have?");
            partySize = int.Parse(Console.ReadLine());

            return partySize;
        }
    }
}
