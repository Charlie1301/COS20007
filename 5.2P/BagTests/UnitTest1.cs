using Iteration_2;

namespace BagTests
{
    public class Tests
    {
       

        [Test]
        public void LocatesItems()
        {

            string[] bag_1_ids = new string[] { "id1", "id2" };

            string bag_1_name = "bag_1_test_bag";

            string bag_1_desc = "bag_1_test_desc";

            Bag test_bag = new Bag(bag_1_ids, bag_1_name, bag_1_desc);

            string[] item_1_ids = new string[] { "id8", "id9" };

            string item_1_name = "item_1_test_name";

            string item_1_desc = "item_1_test_desc";

            Item test_item = new Item(item_1_ids, item_1_name, item_1_desc);


            test_bag.Inventory.Put(test_item);

            Assert.That(test_item == test_bag.Locate("id8"));

        }

        [Test]

        public void LocatesItself()
        {

            string[] bag_1_ids = new string[] { "id1", "id2" };

            string bag_1_name = "bag_1_test_bag";

            string bag_1_desc = "bag_1_test_desc";

            Bag test_bag = new Bag(bag_1_ids, bag_1_name, bag_1_desc);


            Assert.That(test_bag == test_bag.Locate("id1"));

        }

        [Test]

        public void Locatesnothing()
        {

            string[] bag_1_ids = new string[] { "id1", "id2" };

            string bag_1_name = "bag_1_test_bag";

            string bag_1_desc = "bag_1_test_desc";

            Bag test_bag = new Bag(bag_1_ids, bag_1_name, bag_1_desc);


            Assert.That(null == test_bag.Locate("id8"));

        }

        [Test]

        public void FullDescription()
        {

            string[] bag_1_ids = new string[] { "id1", "id2" };

            string bag_1_name = "bag_1_test_bag";

            string bag_1_desc = "bag_1_test_desc";

            Bag test_bag = new Bag(bag_1_ids, bag_1_name, bag_1_desc);

            string[] item_1_ids = new string[] { "id8", "id9" };

            string item_1_name = "item_1_test_name";

            string item_1_desc = "item_1_test_desc";

            Item test_item = new Item(item_1_ids, item_1_name, item_1_desc);

            test_bag.Inventory.Put(test_item);


            Assert.That(test_bag.FullDescription() == "in the bag_1_test_bag you can see:\n   a item_1_test_name (id8)\n");

        }

        [Test]

        public void BagInBag()
        {

            string[] bag_1_ids = new string[] { "id1", "id2" };

            string bag_1_name = "bag_1_test_bag";

            string bag_1_desc = "bag_1_test_desc";

            Bag test_bag_1 = new Bag(bag_1_ids, bag_1_name, bag_1_desc);

            string[] bag_2_ids = new string[] { "id3", "id4" };

            string bag_2_name = "bag_2_test_bag";

            string bag_2_desc = "bag_2_test_desc";

            Bag test_bag_2 = new Bag(bag_2_ids, bag_2_name, bag_2_desc);


            test_bag_1.Inventory.Put(test_bag_2);


            Assert.That(test_bag_2 == test_bag_1.Locate("id3"));

        }
    }
}