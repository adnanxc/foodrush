using System;
using System.Collections.Generic;

namespace FoodRush
{
    public class Processor
    {
        private List<Location> _locations;
        private Location _selectedLocation;
        private Restaurant _selectedRestaurant;
        private Cart _cart;
        private Random _rnd;         //for delivery time

        public Processor()
        {
            _locations = new List<Location>();
            _cart = new Cart();
            _rnd = new Random();
        }

        public void Execute()
        {
            bool order_successful = false;
            LocationProcessor lp = new LocationProcessor();
            RestaurantProcessor rp = new RestaurantProcessor();
            MenuProcessor mp = new MenuProcessor();

            while (!order_successful)
            {
                _selectedLocation = lp.Execute(_locations);

                while (!order_successful)
                {
                    this._selectedRestaurant = rp.Execute(this._selectedLocation);

                    if (this._selectedRestaurant == null)
                    {
                        break;  //goes back to pick location screen
                    }

                    while (!order_successful)
                    {
                        this._cart = mp.Execute(_selectedRestaurant);

                        if (this._cart == null)
                        {
                            this._selectedRestaurant = null;
                            break;
                        }

                        else
                        {
                            if (_cart.GetItems.Count == 0)
                            {
                                Console.WriteLine("\nYour cart is empty!");
                            }

                            else
                            {
                                Console.WriteLine("\n" + _cart.CartSummary());

                                string a = "";
                                while (a == "")
                                {
                                    Console.Write("\nEnter your address: ");
                                    a = Console.ReadLine();
                                    if (a == "")
                                    {
                                        Console.WriteLine("\nAddress cannot be empty!");
                                    }
                                }

                                Console.WriteLine("\nYour Food will be Rushed to you within " + _rnd.Next(20, 40) + " minutes!\n\nThank you for using FoodRush!");

                                order_successful = true; //closes program
                            }
                        }
                    }

                }
            }

            string s = "";


            while(s=="") //Keeps the console from closing
            {
                s = Console.ReadLine();
            }
        }


        public void AddLocation(Location l)
        {
            _locations.Add(l);
        }

    }

}
