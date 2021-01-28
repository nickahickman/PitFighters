using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PitFighters.Input
{
    class InputValidation
    {
        public static bool IsInteger(string response)
        {
            return response.All(char.IsDigit);
        }
    }
}
