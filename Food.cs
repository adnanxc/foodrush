using System;
namespace FoodRush
{
    public class Food : MenuItem
    {

        public Food(string[] name, double price) : base(name, price)
        {
            this._itemType = "Food";
        }

    }
}
