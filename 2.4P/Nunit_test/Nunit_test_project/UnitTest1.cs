using SwinAdventure;
using NUnit.Framework;

namespace _2._4P_tests
{
    public class Tests
    {

        [SetUp]

        public void Setup() { }

        [Test]
        public void Test1()
        {

            //ARRANGE
            string[] input_identifiers = { "id1", "id2", "id3" };


            IdentifiableObject test_object_1 = new IdentifiableObject(input_identifiers);

            string are_you_test_input = "id2";

            //ACT

            bool are_you_return = test_object_1.Are_You(are_you_test_input);

            //ASSERT

            Assert.That(are_you_return);

        }

        [Test]

        public void Test2()
        {
            //ARRANGE
            string[] input_identifiers = { "id1", "id2", "id3" };


            IdentifiableObject test_object_1 = new IdentifiableObject(input_identifiers);

            string are_you_test_input = "id7";

            //ACT

            bool are_you_return = test_object_1.Are_You(are_you_test_input);

            //ASSERT

            Assert.That(!are_you_return);
        }

        [Test]

        public void Test3()
        {
            //ARRANGE
            string[] input_identifiers = { "id1", "id2", "id3" };

            IdentifiableObject test_object_1 = new IdentifiableObject(input_identifiers);

            string are_you_test_input = "ID1";

            //ACT

            bool are_you_return = test_object_1.Are_You(are_you_test_input);

            //ASSERT

            Assert.That(are_you_return);
        }

        [Test]

        public void Test4()
        {
            //ARRANGE

            string[] input_identifiers = { "id1", "id2", "id3" };

            IdentifiableObject test_object_1 = new IdentifiableObject(input_identifiers);

            string first_id_test_string = "id1";

            //ACT

            string first_id = test_object_1.First_id;

            //ASSERT

            Assert.That(first_id_test_string == first_id);
        }

        [Test]

        public void Test5()
        {
            //ARRANGE

            string[] input_identifiers = {};


            IdentifiableObject test_object_1 = new IdentifiableObject(input_identifiers);

            string first_id_test_string = "";

            //ACT

            string first_id = test_object_1.First_id;

            //ASSERT

            Assert.That(first_id_test_string == first_id);
        }

        [Test]

        public void test6()
        {
            //ARRANGE

            string[] input_identifiers = { "id1", "id2"};


            IdentifiableObject test_object_1 = new IdentifiableObject(input_identifiers);

            string new_id_string = "id3";

            //ACT

            test_object_1.Add_Identifier(new_id_string);

            //ASSERT

            Assert.That(test_object_1.Are_You(new_id_string));

        }

    }
}