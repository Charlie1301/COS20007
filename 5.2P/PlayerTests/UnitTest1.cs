using System.Numerics;
using Iteration_2;

namespace PlayerTests
{
    public class Tests
    {

        [Test]

        public void PlayerIdentifiable()
        {
            string test_name = "test_name";

            string test_description = "test_description";
            Player test_player = new Player(test_name, test_description);

            if (test_player.Locate("me", test_player) == test_player)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]

        public void PlayerLocatesItems()
        {
            string test_name = "test_name";

            string test_description = "test_description";
            Player test_player = new Player(test_name, test_description);

            Item test_item = new Item(new string[] { "id1", "id2" }, "item_name", "item_description");

            test_player.Inventory.Put(test_item);

            if (test_player.Locate("id1", test_player) == test_item)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]

        public void PlayerLocatesNothing()
        {
            string test_name = "test_name";

            string test_description = "test_description";
            Player test_player = new Player(test_name, test_description);

            Item test_item = new Item(new string[] { "id1", "id2" }, "item_name", "item_description");

            test_player.Inventory.Put(test_item);

            if (test_player.Locate("id3", test_player) == null)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]

        public void PlayerFullDescription()
        {
            string test_name = "test_name";

            string test_description = "test_description";
            Player test_player = new Player(test_name, test_description);

            Item test_item = new Item(new string[] { "id1", "id2" }, "item_name", "item_description");

            test_player.Inventory.Put(test_item);

            string test_full_description = "You are test_name, test_description. You are carrying:/n   a item_name (id1)/n";

            if (test_player.FullDescription() == test_full_description)
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