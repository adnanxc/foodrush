using System;
namespace FoodRush
{
    public class MenuProcessor
    {
        private Cart _cart;

        public MenuProcessor()
        {
            _cart = new Cart();
        }

        public Cart Execute(Restaurant r) //Returns cart of items
        {
            string menuinput = "";
            bool orderFinished = false;

            while (!orderFinished)
            {
                Console.WriteLine("\n\n" + r.Name + " Menu:\n");
                Console.WriteLine(r.ShowMenu());

                Console.WriteLine("\nSelect item(s) to see more options\nType 'checkout' to confirm order\nType 'back' to see more restaurants:");
                menuinput = Console.ReadLine();
                menuinput = menuinput.ToLower();

                if (menuinput == "back" || menuinput == "go back" || menuinput == "exit")
                {
                    return null;
                }

                if(menuinput == "checkout")
                {
                    return _cart;
                }

                if (r.Menu.HasItem(menuinput))
                {
                    bool exit = false;

                    while (!exit)
                    {
                        MenuItem i = r.Menu.FetchItem(menuinput);
                        Console.WriteLine("\n" + i.Name + "\n      Price: $" + i.Price + "\n\n    -Add to cart\n    -Customize\n    -Back\n\n");
                        string n = Console.ReadLine().ToLower();

                        if (n == "add to cart" || n == "add")
                        {
                            _cart.AddItem(i);
                            Console.WriteLine("\n\n" + i.Name + " successfully added to cart!");
                            exit = true;
                        }

                        else if (n == "customize" || n == "customise")
                        {
                            string m = "";
                            while (exit != true)
                            {
                                Console.WriteLine(r.Menu.ShowAddOns(i) + "\n\nBack");
                                m = Console.ReadLine().ToLower();

                                if (!r.Menu.HasAddOn(m))
                                {
                                    Console.WriteLine("No add-ons available for this item!\n");
                                }

                                if (r.Menu.HasAddOn(m))
                                {
                                    i.AddOn = r.Menu.FetchAddOn(m);
                                    _cart.AddItem(i);
                                    Console.WriteLine("\n\n" + i.Description() + " successfully added to cart!");
                                    exit = true;
                                }

                                else if (m == "back")
                                {
                                    exit = true;
                                }

                                else
                                {
                                    Console.WriteLine("Invalid option");
                                }
                            }
                        }

                        else if (n == "back")
                        {
                            exit = true;
                            
                        }

                        else
                        {
                            Console.WriteLine("Invalid action\n");
                        }
                    }
                }



                else
                {
                    Console.WriteLine("Item not found");
                }
            }

            return null;
        }
    }
}
