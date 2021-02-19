using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak
{
    class Engine
    {
        string type;

        public string Type { get => type; set => type = value; }

        public Engine(string type)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
