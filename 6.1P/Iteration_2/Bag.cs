using System;
using System.Collections.Generic;
using Iteration_2;

namespace Iteration_2
{
    public class Bag : Item, IHaveInventory
    {

        Inventory _inventory = new Inventory();

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc) { }

        public GameObject Locate(string id)
        {

            if (Are_You(id))
            {
                return this;
            } else if (_inventory.HasItem(id))
            {
                return _inventory.Fetch(id);
            } else 
            {
                return new GameObject(new string[] { }, "nil", "nil");
            }

            
        }

        public override string FullDescription()
        {
            return $"In the {Name} you can see:\n{_inventory.ItemList}";
        }

        public Inventory Inventory { get { return _inventory; } }


    }
}