using Iteration_2;

namespace BagTests
{
    public class Tests
    {
       

        [Test]
        public void BagLocatesItems()
        {
            Bag test_bag = new Bag(new string[] { "id1", "id2" }, "test_bag_name", "test_bag_desc");

            Item test_item = new Item(new string[] { "id3", "id4" }, "test_item_name", "test_item_desc");

            test_bag.Inventory.Put(test_item);

            Assert.That(test_bag.Locate("id3") == test_item);

        }

        [Test]

        public void BagLocatesItself()
        {
            Bag test_bag = new Bag(new string[] { "id1", "id2" }, "test_bag_name", "test_bag_desc");

            Assert.That(test_bag.Locate("id1") == test_bag);
        }

        [Test]

        public void BagLocatesNothing()
        {
            Bag test_bag = new Bag(new string[] { "id1", "id2" }, "test_bag_name", "test_bag_desc");

            Assert.That(test_bag.Locate("nil") == new GameObject(new string[] { }, "nil", "nil"));
        }

        [Test]

        public void BagFullDescription()
        {
            Bag test_bag = new Bag(new string[] { "id1", "id2" }, "test_bag_name", "test_bag_desc");

            Item test_item = new Item(new string[] { "id3", "id4" }, "test_item_name", "test_item_desc");

            Assert.That(test_bag.FullDescription() == "In the test_bag_name you can see:\n   a test_item_name (id3)\n");
        }

        [Test]

        public void BagInBag()
        {
            Bag test_bag_1 = new Bag(new string[] { "id1", "id2" }, "test_bag_name", "test_bag_desc");

            Bag test_bag_2 = new Bag(new string[] { "id3", "id4" }, "test_bag_name", "test_bag_desc");

            Item test_item_1 = new Item(new string[] { "id5", "id6" }, "test_item_name", "test_item_desc");

            Item test_item_2 = new Item(new string[] { "id7", "id8" }, "test_item_name", "test_item_desc");

            test_bag_1.Inventory.Put(test_item_1);

            test_bag_2.Inventory.Put(test_item_2);

            test_bag_1.Inventory.Put(test_bag_2);


            Assert.That(
                (test_bag_1.Locate("id3") == test_bag_2) && 
                (test_bag_1.Locate("id5") == test_item_1) && 
                (!(test_bag_1.Locate("id7") == test_item_2)));

        }

    }
}