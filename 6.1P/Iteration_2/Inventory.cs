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

            int index = 0;

            int item_index = 0;

            foreach (Item item in _items)
            {
                if (item.Are_You(identifier))
                { 
                    
                    item_index = index;

                }

                index++;
            }

            Item return_item = _items[item_index];

            _items.RemoveAt(item_index);

            return return_item;

        }

        public Item Fetch(string identifier) {

            int index = 0;

            int item_index = 0;

            foreach (Item item in _items)
            {
                if (item.Are_You(identifier))
                {
                    item_index= index;
                }

                index++;
            }

            return _items[item_index];

        }

        public String ItemList
        {

            get
            {

                string itemlist = "";

                foreach (Item item in _items)
                {

                    itemlist += $"   {item.ShortDescription}\n";

                }

                return itemlist;

            }

        }

    }


}