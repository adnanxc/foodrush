using System;
namespace FoodRush
{
    public abstract class MenuItem : IdentifiableObject
    {
        private double _price;
        private AddOn _addon;       //one item can have one addon at this stage
        protected string _itemType;

        public MenuItem(string[] name, double price) : base(name)
        {
            _price = price;
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public string ItemType
        {
            get
            {
                return  _itemType;
            }
        }

        public bool HasAddOn()
        {
            if(_addon != null)
            {
                return true;
            }

            return false;
        }

        public AddOn AddOn
        {
            get
            {
                return _addon;
            }
            set
            {
                _addon = value;
            }
        }

        public string Description()
        {
            if (this.HasAddOn())
            {
                return this.Name + " (" + this.AddOn.Name + ")";
            }

            return this.Name;
        }
    }
}
