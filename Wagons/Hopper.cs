using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak.Wagons
{
    class Hopper : Wagon
    {
        private double loadingCapacity;

        public Hopper(double loadingCapacity)
        {
            LoadingCapacity = loadingCapacity;
        }

        public double LoadingCapacity { get => loadingCapacity; set => loadingCapacity = value; }

        public override string ToString()
        {
            return $"Vagon typu Hopper s kapacitou {LoadingCapacity}t \r\n"; 
        }
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
