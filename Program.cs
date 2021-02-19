using System;
using Vlak.Wagons;

namespace Vlak
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine("Diesel");
            Person ridicLoko = new Person("Pepa", "Novak");
            Person stewardka = new Person("Lenka", "Kozáková");
            Locomotive loco1 = new Locomotive(ridicLoko, engine);
            BusinessWagon business2 = new BusinessWagon(20, stewardka);
            NightWagon night2 = new NightWagon(10, 15);
            Hopper hopper1 = new Hopper(200);


            Train train = new Train(loco1);
            train.ConnectWagon(business2);
            train.ConnectWagon(night2);
            train.ConnectWagon(hopper1);

            train.ReserveChair(1, 1);
            //train.ListReservedChairs();

            Engine engineParni = new Engine("Parni");
            Locomotive loco2= new Locomotive(ridicLoko, engineParni);
            Train train2 = new Train(loco2);
            BusinessWagon business = new BusinessWagon(20, stewardka);
            NightWagon night = new NightWagon(10, 15);
            Hopper hopper = new Hopper(200);
            Hopper hopper2 = new Hopper(200);
            Hopper hopper3 = new Hopper(200);
            Hopper hopper4 = new Hopper(200);
            train2.ConnectWagon(business);
            train2.ConnectWagon(hopper);
            train2.ConnectWagon(night);
            train2.ConnectWagon(hopper2);
            train2.ConnectWagon(hopper3);
            train2.ConnectWagon(hopper4);
            train2.ReserveChair(3, 1);
            train2.ListReservedChairs();
            train2.ReserveChair(2, 1);  // rezervace v hopperu
            train2.ReserveChair(3, 1); // opetovna rezervace

            Console.WriteLine(train.ToString());
            Console.WriteLine(train2.ToString());
        }
    }
}
