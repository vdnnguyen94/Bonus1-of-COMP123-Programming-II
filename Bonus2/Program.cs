using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plane> PlaneList = new List<Plane>();
            PlaneList.Add(new Plane("Boeing", "Sx500 ", 450, "Passenger", "02145"));
            PlaneList.Add(new Plane("Airbus","02ZD",255,"Passenger","24AD230"));
            PlaneList.Add(new Plane("Delta", "Fighter-Jet ", 2, "Military", "X0015"));
            PlaneList.Add(new Plane("United AirCraft", "UACCargo05", 60, "Cargo", "89D220"));
            PlaneList.Add(new Plane());
            int[] capacityList = new int[] { 20, 50, 100, 300, 500 } ;
            Console.WriteLine("Plane in the List");
            foreach (Plane plane in PlaneList)
            {
                Console.WriteLine((PlaneList.IndexOf(plane) + 1).ToString() + " " + plane.ToString());
            }
            do
            {
                Console.Write("Enter 0 to Exit\nOr Enter the Index of Plane you would like to check Capacity(1-5)\nYour choice:    ");
                string choice = Console.ReadLine();
                string Capacity = "";
                string NoCapacity = "";
                int i = 0;
                int y = 0;
                if (choice == "0") { break; }
                else if (Convert.ToInt32(choice) >= 1 && Convert.ToInt32(choice) <= PlaneList.Count)
                {
                    int planeIndex = Convert.ToInt32(choice) -1;
                    foreach (int capacity in capacityList)
                    {
                        if (PlaneList[planeIndex].HasCapcity(capacity))
                        { if (i == 0) { Capacity = capacity.ToString(); i++; }
                            else { Capacity = Capacity + "," + capacity.ToString(); } }
                        else { if (y == 0) { NoCapacity = capacity.ToString(); y++; }
                            else { NoCapacity = NoCapacity + "," + capacity.ToString(); } }
                    }
                    string[] CapacityNumber = Capacity.Split(',');
                    string[] NoCapacityNumber = NoCapacity.Split(',');
                    Console.WriteLine("This Plane can have space for : "+string.Join(",",CapacityNumber));
                    Console.WriteLine("This Plane DOES NOT  have space for : " + string.Join(",", NoCapacityNumber));
                }
                else { Console.WriteLine("INVALID CHOICE"); }
            }
            while (true);
        }
    }
}
