﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _731909
{
    class Program
    {
        static void Main(string[] args)
        {
            //new inder().kharoud();
            var a = new CountrySide();
            a.Run();


            Console.WriteLine(UsingRecursion.CalculateRecursively(3, 4));


        }

        class inder
        {
            static int j = 0;

            public void  kharoud()
            {
                //let's write a trace message
               
                Console.WriteLine(inder.j++);
                int Sum = 0;
                Sum += 1;
                kharoud();

            }
        }


        class UsingRecursion
        {
            // Create an application which 
            // calculates the sum of all the numbers from n to m recursively:

            public static int CalculateRecursively(int n, int m)
            {
                int sum = n;

                if (n < m)
                {
                    n++;
                    return sum += CalculateRecursively(n, m);
                }
                return sum;
            }


        }

        class CountrySide
        {
            // Create the LinkedList to reflect the Map in the PowerPoint Instructions
            Village Maeland;
            Village Helmholtz;
            Village Alst;
            Village Wessig;
            Village Badden;
            Village Uster;
            Village Schvenig;

            public void Run()
            {
                Village Alst = new Village("Alst", false);
                Village Schvenig = new Village(" Schvenig ", false);
                Village Wessig  = new Village("Wessig", true);
                Alst.west = Schvenig;
                Alst.east = Wessig;
                Alst.distanceToWestVillage = 14;
                Alst.distanceToEastVillage = 19;

                
            }
            public void travelVillages()
            {

            }
        }


            class Village
            {
                public Village(string _villageName, bool _isAHere)
                {
                    isAstrildgeHere = _isAHere;
                    VillageName = _villageName;
                }

                public Village west;
                public Village east;
                public string VillageName;
                public int distanceToNextVillage;
            public int distanceToWestVillage;
            public int distanceToEastVillage;
            public int distanceToPreviousVillage;
                public bool isAstrildgeHere;
            }

        }
    }
}
