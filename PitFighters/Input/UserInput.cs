using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    public class UserInput
    {
        public static string GetStringResponse(string prompt)
        {
            string userResponse;

            Console.Write(prompt);
            userResponse = Console.ReadLine().Trim();

            while (String.IsNullOrEmpty(userResponse))
            {
                Console.WriteLine("I need you to enter something. Silence isn't a virtue here!");
                userResponse = GetStringResponse(prompt);
            }

            return userResponse;
        }

        public static int GetIntegerResponse(string prompt)
        {
            string userResponse = GetStringResponse(prompt);
            int integer;

            while (!Input.InputValidation.IsInteger(userResponse))
            {
                userResponse = GetStringResponse($"Invalid response. {prompt}");
            }

            integer = int.Parse(userResponse);
            integer--;

            return integer;
        }
    }
}
