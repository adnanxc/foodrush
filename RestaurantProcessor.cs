using System;
namespace FoodRush
{
    public class RestaurantProcessor
    {

        

        public RestaurantProcessor()
        {
        }

        public Restaurant Execute(Location _selectedLocation) //Returns selected restaurant
        {
            string s = "";
            Restaurant _restaurant = null;

            while (_restaurant == null)
            {
                Console.WriteLine("\n\nAvailable restaurants in " +_selectedLocation.Name + ":\n");
                Console.WriteLine(_selectedLocation.RestaurantList());

                Console.WriteLine("\nSelect a restaurant to see its menu, or change location to see more restaurants");
                s = Console.ReadLine();

                if(s.ToLower() == "change" || s.ToLower() == "change location" || s.ToLower() == "back")
                {
                    return null;
                }
                _restaurant = _selectedLocation.GetRestaurant(s);


                if (_restaurant == null)
                {
                    Console.WriteLine("\nInvalid Restaurant");
                }
            }

            return _restaurant;
        }
    }
}
