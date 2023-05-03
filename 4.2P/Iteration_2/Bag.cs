using System;
using System.Collections.Generic;
using Iteration_2;

namespace Iteration_2
{
    public class Bag
    {

        Inventory _inventory = new Inventory();

        string[] _identifiers;

        string _name;

        string _description;

        public Bag(string[] ids, string name, string desc)
        {
            _identifiers = ids;

            _name = name;

            _description = desc;
        }

        public string[] Identifiers() { return _identifiers; }

        public void Add(Item item)
        {
            _inventory.Put(item);
        }

        public dynamic Locate(Bag self, string find_id)
        {

            if (FindSelf(find_id))
            {
                return self;

            } else if (IsBag(find_id))
            {
                return FindBag(find_id);

            } else if (HasItem(find_id))
            {
                return _inventory.Fetch(find_id);

            } else
            {
                return null;
            }

            
        }

        public string FullDescription()
        {
            return $"In the {_name} you can see:/n{_inventory.ItemList}";
        }

        public bool FindSelf(string check_id)
        {

            bool return_value = false;

            foreach (string id in _identifiers)
            {
                if (id == check_id)
                {
                    return true;
                }
            }

            return return_value;
        }

        public bool IsBag(string check_id)
        {

            bool return_value = false;

            foreach (Bag bag in _inventory.Bags())
            {
                foreach (string id in bag.Identifiers())
                {
                    if (id == check_id)
                    {
                        return_value = true;
                    }
                }
            }

            return return_value;
        }

        public Bag FindBag(string check_id)
        {
            Bag bag_ = new Bag(new string[] { }, "null_name", "null_desc");
            bool found = false;
            foreach (Bag bag in _inventory.Bags())
            {
                foreach (string id in bag.Identifiers())
                {
                    if (id == check_id)
                    {
                        found = true;
                        bag_ = bag;
                    }
                }
            }

            if (found) { return bag_; } else { return null; }
        }

        public bool HasItem(string check_id)
        {
            return _inventory.HasItem(check_id);
        }


    }
}