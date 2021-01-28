using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    class GameManager
    {
        public void Run()
        {
            while (true)
            {
                WelcomeMessage();

                int partySize = UserInput.GetIntegerResponse("How many fighters will each party have? ");
                GameState gs = new GameState(partySize);

                BattleManager.PrintParty(gs.PlayerOneFighters);
                BattleManager.PrintParty(gs.PlayerTwoFighters);

                if (UserContinue.UserWantsToContinue("Play again? ", "I didn't understand that"))
                {
                    Console.Clear();
                }
                else 
                {
                    break;
                }
            }
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to pit fighters!!");
            Console.WriteLine("-------------------------");
        }
    }
}
