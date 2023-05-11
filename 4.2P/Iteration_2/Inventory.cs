using System;
using System.Collections.Generic;
using Iteration_2;

namespace Iteration_2 {

    public class Inventory {

        private List<Item> _items = new List<Item> { };

        public Inventory() { }

        public bool HasItem(string test_id) {

            bool hasitem = false;

            foreach (Item item in _items) {

                if (item.Are_You(test_id))
                {
                    hasitem = true;
                }

            }

            return hasitem;

        }

        public void Put(Item new_item) {

            _items.Add(new_item);
        
        }

        public Item Take(string identifier) {

            Item return_item = new Item(new string[] { }, "null", "null");

            foreach (Item item in _items)
            {
                if (item.Are_You(identifier))
                {

                    return_item = item;

                    _items.Remove(item);

                }
            }

            return return_item;

        }

        public Item Fetch(string identifier) {

            Item return_item = new Item(new string[] { }, "null", "null");

            foreach (Item item in _items)
            {
                if (item.Are_You(identifier))
                {
                    return_item = item;
                }

            
            }

            return return_item;

        }

        public String ItemList
        {

            get
            {

                string itemlist = "";

                foreach (Item item in _items)
                {

                    itemlist += $"   {item.ShortDescription}/n";

                }

                return itemlist;

            }

        }

    }


}