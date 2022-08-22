using System;
using System.Collections.Generic;
namespace FoodRush
{
    public class Menu
    {
        private List<MenuItem> _itemList;
        private List<AddOn> _addOns;

        public Menu()
        {
            _itemList = new List<MenuItem>();
            _addOns = new List<AddOn>();
        }

        public List<MenuItem> ItemList
        {
            get
            {
                return _itemList;
            }
        }

        public List<AddOn> AddOns
        {
            get
            {
                return _addOns;
            }
        }

        public string ShowItems()
        {
            string s = "";
            List<string> types = new List<string>();
            string temp = "";


            foreach (MenuItem i in _itemList)
            {
                temp = i.ItemType;
                if (!types.Contains(temp))
                {
                    types.Add(i.ItemType);
                }
            }

            foreach(string x in types)
            {
                s += "\n" + x + ":\n\n";
                foreach (MenuItem i in _itemList)
                {
                    if (i.ItemType == x)
                    {
                        s += "  " + i.Name + "\n        Price: $" + i.Price + "\n";
                    }
                }
            }

            return s;
            
        }

        public string ShowAddOns(MenuItem i)
        {
            string s = "";
            foreach(AddOn a in _addOns)
            {
                if(i.ItemType == a.Type)
                {
                    s += "\n    " + a.Name ;
                }
            }

            return s;
        }

        public MenuItem FetchItem(string s)
        {
            foreach(MenuItem i in _itemList)
            {
                if (i.AreYou(s))
                {
                    return i;
                }
            }

            return null;
        }

        public bool HasItem(string s)
        {
            foreach (MenuItem i in _itemList)
            {
                if (i.AreYou(s))
                {
                    return true;
                }
            }

            return false;
        }

        public AddOn FetchAddOn(string s)
        {
            foreach (AddOn a in _addOns)
            {
                if (a.AreYou(s))
                {
                    return a;
                }
            }

            return null;
        }

        public bool HasAddOn(string s)
        {
            foreach (AddOn a in _addOns)
            {
                if (a.AreYou(s))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
