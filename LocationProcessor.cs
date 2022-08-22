using System;
using System.Collections.Generic;

namespace FoodRush
{
    public class LocationProcessor
    {

        

        public LocationProcessor()
        {
            
        }

        public Location Execute(List<Location> _locations)  //Returns selected location
        {
            bool locationPicked = false;
            string s = "";

            while (!locationPicked)
            {
                Console.WriteLine("\nAvailable locations:\n");
                foreach (Location l in _locations)
                {
                    Console.WriteLine(l.Name);
                }

                Console.Write("\nSelect a location to view the list of available restaurants: ");
                s = Console.ReadLine();

                foreach (Location l in _locations)
                {
                    if (l.AreYou(s))
                    {
                        return l;
                    }
                }

                if (!locationPicked)
                {
                    Console.WriteLine("\nInvalid location");
                }
            }

            return null;
        }
    }
}
