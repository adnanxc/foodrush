using System;
namespace FoodRush
{
    public class Drink : MenuItem
    {
        public Drink(string[] name, double price) : base(name, price)
        {
            this._itemType = "Drink";
        }
    }
}
