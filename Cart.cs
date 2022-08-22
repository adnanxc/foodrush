using System;
using System.Collections.Generic;

namespace FoodRush
{
    public class Cart
    {
        private List<MenuItem> _items;
        private double _cartTotal;

        public Cart()
        {
            _items = new List<MenuItem>();
            _cartTotal = 0;
        }

        public void AddItem(MenuItem i)
        {
            _items.Add(i);
            _cartTotal += i.Price;
        }

        public List<MenuItem> GetItems
        {
            get
            {
                return _items;
            }
        }

        public string CartSummary()
        {
            string s = "Items in cart:\n";

            List<string> types = new List<string>();
            string temp = "";


            foreach (MenuItem i in _items)
            {
                temp = i.ItemType;
                if (!types.Contains(temp))      //gathers different types of menu items
                {
                    types.Add(i.ItemType);
                }
            }

            foreach (string x in types)
            {
                s += "\n" + x + ":\n\n";
                foreach (MenuItem i in _items)
                {
                    if (i.ItemType == x)
                    {
                        s += "      " + i.Description() + "\n";
                    }
                }
            }

            s += "\nTotal: $" + Math.Round(_cartTotal, 2);

            return s;
        }


    }
}
