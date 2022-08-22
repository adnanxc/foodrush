using System;
namespace FoodRush
{
    public class Restaurant : IdentifiableObject
    {
        private Menu _menu;

        public Restaurant(string[] name) : base(name)
        {
            _menu = new Menu();
        }


        public void AddItem(MenuItem i)
        {
            _menu.ItemList.Add(i);
        }

        public void AddAddOn(AddOn a)
        {
            _menu.AddOns.Add(a);
        }

        public string ShowMenu()
        {
            return _menu.ShowItems();
        }

        public Menu Menu
        {
            get
            {
                return _menu;
            }
        }
    }
}
