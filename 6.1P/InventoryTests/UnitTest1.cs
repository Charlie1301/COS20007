using Iteration_2;

namespace InventoryTests
{
    public class Tests
    {

        [Test]

        public void InventoryFindItem()
        {

            Inventory test_inventory = new Inventory();

            var test_identifiers = new string[] { "id1", "id2", "id3" };

            string test_name = "test_name";

            string test_description = "test_description";

            Item new_item = new Item(test_identifiers, test_name, test_description);

            test_inventory.Put(new_item);

            if (test_inventory.HasItem("id1"))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]

        public void InventoryNoItemFind()
        {

            Inventory test_inventory = new Inventory();

            var test_identifiers = new string[] { "id1", "id2", "id3" };

            string test_name = "test_name";

            string test_description = "test_description";

            Item new_item = new Item(test_identifiers, test_name, test_description);

            test_inventory.Put(new_item);

            if (test_inventory.HasItem("id4"))
            {
                Assert.Fail();
            }
            else
            {
                Assert.Pass();
            }
        }

        [Test]

        public void InventoryFetch()
        {

            bool fetch_bool = false;

            bool fetch_remains = false;



            var test_identifiers = new string[] { "id1", "id2", "id3" };

            string test_name = "test_name";

            string test_description = "test_description";

            Item test_item = new Item(test_identifiers, test_name, test_description);

            Inventory test_inventory = new Inventory();

            test_inventory.Put(test_item);

            Item item_fetched = test_inventory.Fetch("id1");



            if (item_fetched == test_item) { fetch_bool = true; }

            if (test_inventory.HasItem("id1")) { fetch_remains = true; }

            if (fetch_bool && fetch_remains)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]

        public void InventoryTake()
        {
            bool take_bool = false;

            bool take_is_gone = false;



            var test_identifiers = new string[] { "id1", "id2", "id3" };

            string test_name = "test_name";

            string test_description = "test_description";

            Item test_item = new Item(test_identifiers, test_name, test_description);

            Inventory test_inventory = new Inventory();

            test_inventory.Put(test_item);



            Item item_taken = test_inventory.Take("id1");



            if (item_taken == test_item) { take_bool = true; }

            if (!(test_inventory.HasItem("id1"))) { take_is_gone = true; }

            if (take_bool && take_is_gone)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]

        public void InventoryItemList()
        {
            var test_identifiers = new string[] { "id1", "id2", "id3" };

            string test_name = "test_name";

            string test_description = "test_description";

            Item test_item = new Item(test_identifiers, test_name, test_description);

            Inventory test_inventory = new Inventory();

            test_inventory.Put(test_item);


            string item_string = test_inventory.ItemList;

            if (item_string == $"   a test_name (id1)/n")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}