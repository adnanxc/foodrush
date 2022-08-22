using System;
namespace FoodRush
{
    public class AddOn : IdentifiableObject
    {
        private string _type;       //indicates which type of foods can have this addon

        public AddOn(string[] name, string type) : base(name)
        {
            _type = type;
        }

        public string Type
        {
            get
            {
                return _type;
            }
        }
        
    }
}
