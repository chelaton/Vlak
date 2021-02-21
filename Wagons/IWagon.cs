using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak.Wagons
{
    interface IWagon
    {
        public void ConnectWagon(Train train) { }
        public void DisconnectWagon(Train train) { }
    }
}
