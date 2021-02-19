using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak
{
    class Chair
    {
        bool nearWindow;
        int number;
        bool reserved;

        public Chair()
        {
            Reserved = false;
        }

        public Chair(bool nearWindow, int number, bool reserved)
        {
            NearWindow = nearWindow;
            Number = number;
            Reserved = reserved;
        }

        public bool NearWindow { get => nearWindow; set => nearWindow = value; }
        public int Number { get => number; set => number = value; }
        public bool Reserved { get => reserved; set => reserved = value; }
    }
}
