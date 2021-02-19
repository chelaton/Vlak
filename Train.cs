using System;
using System.Collections.Generic;
using System.Text;
using Vlak.Wagons;

namespace Vlak
{
    class Train
    {
        private Locomotive locomotive;
        private List<Wagon> wagons;

        public Train()
        {
        }

        public Train(Locomotive locomotive)
        {
            Locomotive = locomotive;
            wagons = new List<Wagon>();
        }

        public Train(Locomotive locomotive, List<Wagon> wagons)
        {
            Locomotive = locomotive;
            Wagons = wagons;
        }

        internal Locomotive Locomotive { get => locomotive; set => locomotive = value; }
        internal List<Wagon> Wagons { get => wagons; set => wagons = value; }

        public void ConnectWagon(Wagon wagon)
        {
            if (Locomotive.Engine.Type == "Parni" && wagons.Count>=5)
            {
                Console.WriteLine($"Neni mozne pridat dalsi vagon! Parni loko utahne jen 5.");
            }
            else
            {
                wagons.Add(wagon);
            }
            
        }
        public void DisconnectWagon(Wagon wagon)
        {
            if (wagons.Contains(wagon))
            {
                wagons.Remove(wagon);
            }
            else
            {
                Console.WriteLine($"Tento wagon neni soucasti vlaku!");
            }

        }

        public void ReserveChair(int numberOfWagon, int numberOfSeat)
        {
            int indexVagonu = numberOfWagon - 1;
            if (wagons[indexVagonu].GetType().BaseType == typeof(PersonalWagon) && wagons.Count >= numberOfWagon)
            {

                if (numberOfSeat < ((PersonalWagon)wagons[indexVagonu]).NumberOfChairs)
                {

                   if (((PersonalWagon)wagons[indexVagonu]).Sits[numberOfSeat].Reserved == false)
                    {
                        ((PersonalWagon)wagons[indexVagonu]).Sits[numberOfSeat].Reserved = true;
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
                Console.WriteLine($"Snazite se rezervovat misto ve vlaku typu {wagons[indexVagonu].GetType().Name}");
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
                        if (sedadlo.Reserved==true)
                        {
                            Console.WriteLine($"cislo {sedadlo.Number} ve vagonu cislo {i+1}");
                        }
                    } 
                }
                
                i++;
            } 


        }
        public override string ToString()
        {
            string s = "";
            s += $"{locomotive.ToString()}";
            foreach (var wagon in Wagons)
            {
                s += wagon.ToString();
            }
            return s;
        }
    }
}
