using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak
{
    class NightWagon : PersonalWagon
    {
        private Bed[] beds;
        private int numberOfBeds;
        public NightWagon(int numberOfChairs, int numberOfBeds) : base(numberOfChairs)
        {
            NumberOfBeds = numberOfBeds;
            this.Beds = new Bed[numberOfBeds];
            for (int i = 0; i < numberOfBeds; i++)
            {
                Beds[i] = new Bed(false);
            }
        }

        public int NumberOfBeds { get => numberOfBeds; set => numberOfBeds = value; }
        internal Bed[] Beds { get => beds; set => beds = value; }

        public override string ToString()
        {
            return $"{this.GetType().Name} wagon a poctem lehatek {NumberOfBeds} \r\n"; ;
        }
    }
}
