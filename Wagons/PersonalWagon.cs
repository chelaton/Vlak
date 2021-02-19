using System;
using System.Collections.Generic;
using System.Text;
using Vlak.Wagons;

namespace Vlak
{
    abstract class PersonalWagon : Wagon
    {
        List<Door> doors;
        Chair[] sits;
        int numberOfChairs;

        public PersonalWagon(int numberOfChairs)
        {
            this.NumberOfChairs = numberOfChairs;
            this.Sits = new Chair[numberOfChairs];
            for (int i = 0; i < numberOfChairs; i++)
            {
                Sits[i] = new Chair(true, i, false);
            }
        }

        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }
        internal List<Door> Doors { get => doors; set => doors = value; }
        internal Chair[] Sits { get => sits; set => sits = value; }

        public void ConnectWagon(Train train)
        {
            train.ConnectWagon(this);
        }
        public void DisconnectWagon(Train train)
        {
            train.DisconnectWagon(this);
        }

    }

}
