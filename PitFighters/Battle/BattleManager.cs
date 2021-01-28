using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    class BattleManager
    {
        private List<string> Weapons { get; set; } = new List<string>()
        {
            "Crossbow",
            "Spear",
            "Sword & Shield",
            "Warhammer",
            "Dagger"
        };
        public void RunBattle()
        {

        }

        public void RunSkirmish()
        {

        }

        public string SelectWeapon()
        {
            return "";
        }

        public void PrintPartyRosters(GameState gs)
        {

        }

        public static void PrintParty(List<Fighter> party)
        {
            foreach(Fighter f in party)
            {
                Console.WriteLine(f.Name);
            }
        }
    }
}
