using System;
using System.Collections.Generic;
using System.ComponentModel;
using Iteration_2;

namespace Iteration_2 {

    public class Player : GameObject {

        private Inventory _inventory = new Inventory();

        public Player(string name, string description) : base(new string[] {"me", "Inventory"}, name, description) {}

        public String FullDescription()
        {
            return $"You are {Name}, {ShortDescription}. You are carrying:\n{_inventory.ItemList}";
        }

        public Inventory Inventory
        {
            get { return _inventory; }
        }

        public GameObject Locate(string check_id, Player self)
        {
            if (check_id == "me" || check_id == "inventory")
            {
                return self;

            }
            else if (self.Inventory.HasItem(check_id))
            {
                return self.Inventory.Fetch(check_id);

            }
            else
            {
                return null;
            }
        }

    }

}