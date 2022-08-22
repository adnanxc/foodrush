using System;
using System.Collections.Generic;
namespace FoodRush
{
    public abstract class IdentifiableObject
    {

        private List<string> _identifiers;
        private List<string> _names;

        public IdentifiableObject(string[] idents)
        {
            _identifiers = new List<string>();
            _names = new List<string>();

            foreach (string s in idents)
            {
                AddIdentifier(s);
                AddName(s);
            }
        }

        
        

        public bool AreYou(string id)
        {
            id = id.ToLower();
            foreach (string s in _identifiers)
            {
                if (s == id)
                {
                    return true;
                }

            }

            return false;
        }


        public string FirstId
        {
            get
            {
                if (_identifiers.Count == 0)
                {
                    return "";
                }
                return _identifiers[0];
            }
        }

        public virtual string Name
        {
            get
            {
                if (_names.Count == 0)
                {
                    return "";
                }
                return _names[0];
            }
        }

        public void AddIdentifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }

        public void AddName(string name)
        {
            _names.Add(name);
        }
    }
}



