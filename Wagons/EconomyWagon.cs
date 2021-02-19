using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak
{
    class EconomyWagon : PersonalWagon
    {
        public EconomyWagon(int numberOfChairs) : base(numberOfChairs)
        {
        }
        public override string ToString()
        {
            return $"{this.GetType()} wagon a poctem sedadel {NumberOfChairs}"; 
        }
    }
}
