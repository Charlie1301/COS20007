using Clock_Class;
using CounterTask;

namespace counter_Test
{
    internal class counter_Tests
    {
        [Test]

        public void counterInitializeStartsAtZero()
        {
            Counter test_counter = new Counter("test");

            Assert.That(test_counter.Count == 0);
        }

        [Test]
        public void counterIncrementAddsOne()
        {
            Counter test_counter = new Counter("test");

            test_counter.Increment();

            Assert.That(test_counter.Count == 1);
        }
        [Test]
        public void counterMultipleIncrementWorks()
        {
            Counter test_counter = new Counter("test");

            for (int i = 0; i < 15; i++) { test_counter.Increment(); }

            Assert.That(test_counter.Count == 15);

        }
        [Test]
        public void counterResetWorks()
        {
            Counter test_counter = new Counter("test");

            for (int i = 0; i < 15; i++) { test_counter.Increment(); }

            test_counter.Reset();

            Assert.That(test_counter.Count == 0);
        }
    }
}
