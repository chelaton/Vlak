using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak
{
    class Bed
    {
        int number;
        bool reserved;

        public Bed()
        {
        }

        public Bed(bool reserved)
        {
            Reserved = reserved;
        }

        public int Number { get => number; set => number = value; }
        public bool Reserved { get => reserved; set => reserved = value; }
    }
}
