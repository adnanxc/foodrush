using System;
using System.Collections.Generic;
namespace FoodRush
{
    public class Location : IdentifiableObject
    {

        private List<Restaurant> _restaurants;

        public Location(string[] name) : base(name)
        {
            _restaurants = new List<Restaurant>();
        }

        public void AddRestaurant(Restaurant r)
        {
            _restaurants.Add(r);
        }

        public string RestaurantList()
        {
            string s = "";
            foreach (Restaurant r in _restaurants)
            {
                s += r.Name + "\n";
            }
            return s;
        }

        public Restaurant GetRestaurant(string s)
        {
           foreach(Restaurant r in _restaurants)
            {
                if (r.AreYou(s))
                {
                    return r;
                }
            }

            return null;
        }


    }
}
