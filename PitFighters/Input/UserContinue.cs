using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    class UserContinue
    {
        public static bool UserWantsToContinue(string originalQuery, string errorMessage)
        {
            string userResponse = UserInput.GetStringResponse($"{originalQuery} (y/n): ").ToLower(); ;

            while (userResponse != "n" && userResponse != "y")
            {
                userResponse = UserInput.GetStringResponse($"{errorMessage} {originalQuery} (y/n)").ToLower();
            }

            if (userResponse == "n")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
