using System;
using System.Collections.Generic;
using System.Text;
using Vlak.Wagons;

namespace Vlak
{
    class Train
    {
        private Locomotive locomotive;
        private List<IWagon> wagons;

        internal Locomotive Locomotive { get => locomotive; set => locomotive = value; }
        internal List<IWagon> Wagons { get => wagons; set => wagons = value; }

        public Train()
        {
        }

        public Train(Locomotive locomotive, List<IWagon> wagons)
        {
            Locomotive = locomotive;
            Wagons = wagons;
        }

        public Train(Locomotive locomotive)
        {
            Locomotive = locomotive;
            Wagons = new List<IWagon>();
        }

        public void ConnectWagon(IWagon wagon)
        {
            if (Locomotive.Engine.Type == "Parni" && Wagons.Count >= 5)
            {
                Console.WriteLine($"Neni mozne pridat dalsi vagon! Parni loko utahne jen 5.");
            }
            else
            {
                Wagons.Add(wagon);
            }

        }
        public void DisconnectWagon(IWagon wagon)
        {
            if (Wagons.Contains(wagon))
            {
                Wagons.Remove(wagon);
            }
            else
            {
                Console.WriteLine($"Tento wagon neni soucasti vlaku!");
            }

        }

        public void ReserveChair(int numberOfWagon, int numberOfSeat)
        {
            int indexVagonu = numberOfWagon - 1;
            if (Wagons[indexVagonu].GetType().BaseType == typeof(PersonalWagon) && Wagons.Count >= numberOfWagon)
            {

                if (numberOfSeat < ((PersonalWagon)Wagons[indexVagonu]).NumberOfChairs)
                {

                    if (((PersonalWagon)Wagons[indexVagonu]).Sits[numberOfSeat].Reserved == false)
                    {
                        ((PersonalWagon)Wagons[indexVagonu]).Sits[numberOfSeat].Reserved = true;
                    }
                    else
                    {
                        Console.WriteLine($"Je mi lito ale sedadlo {numberOfSeat} ve vagonu cislo {numberOfWagon} je jiz rezervovano!");
                    }
                }
                else
                {
                    Console.WriteLine($"Je mi lito ale sedadlo {numberOfSeat} ve vagonu cislo {numberOfWagon}  neexistuje!");
                }
            }
            else
            {
                Console.WriteLine($"Snazite se rezervovat misto ve vlaku typu {Wagons[indexVagonu].GetType().Name}");
            }

        }

        public void ListReservedChairs()
        {
            Console.WriteLine($"List rezervovanych sedadel");
            int i = 0;
            foreach (var vagon in Wagons)
            {
                if (vagon.GetType().BaseType == typeof(PersonalWagon))
                {
                    foreach (var sedadlo in ((PersonalWagon)vagon).Sits)
                    {
                        if (sedadlo.Reserved == true)
                        {
                            Console.WriteLine($"cislo {sedadlo.Number} ve vagonu cislo {i + 1}");
                        }
                    }
                }

                i++;
            }


        }
        public override string ToString()
        {
            string s = "";
            s += $"{Locomotive.ToString()}";
            foreach (var wagon in Wagons)
            {
                s += wagon.ToString();
            }
            return s;
        }
    }
}
