using Iteration_2;

namespace Iteration_2_tests
{
    public class Tests
    {

        [Test]
        public void Item_Identifiable()
        {

            string[] test_identifiers = new string[] { "id1", "id2", "id3" };

            string test_name = "test_item";

            string test_description = "test_description";

            Item test_item = new Item(test_identifiers, test_name, test_description);



            bool test_are_you = test_item.Are_You("id2");


            if (test_are_you)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]

        public void Item_ShortDescription()
        {

            string[] test_identifiers = new string[] { "sword", "id2", "id3" };

            string test_name = "bronze sword";

            string test_description = "test_description";

            Item test_item = new Item(test_identifiers, test_name, test_description);


            string test_short_description = test_item.ShortDescription;

            if (test_short_description == "a bronze sword (sword)")
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]

        public void Item_FullDescription()
        {

            string[] test_identifiers = new string[] { "id1", "id2", "id3" };

            string test_name = "test_name";

            string test_description = "test_description";

            Item test_item = new Item(test_identifiers, test_name, test_description);


            string test_full_description = test_item.FullDescription();

            if (test_full_description == "test_description")
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