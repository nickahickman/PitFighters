using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    class GameState
    {
        public List<Fighter> PlayerOneFighters { get; set; }
        public List<Fighter> PlayerTwoFighters { get; set; }

        public int PartySize { get; set; } // lol

        public GameState(int partySize)
        {
            PlayerOneFighters = BuildParty.BuildFighterParty(1, partySize);
            PlayerTwoFighters = BuildParty.BuildFighterParty(2, partySize);
        }
    }
}
