using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    public class Fighter
    {
        public string Name { get; set; }
        public string Weapon { get; set; } = "Unarmed";

        public Fighter(string name)
        {
            Name = name;
        }
    }
}
