using Clock_Class;
using CounterTask;

namespace Clock_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void clockInitializeStartsAtZero()
        {

            Clock test_clock = new Clock();

            Assert.That(test_clock.Time == "00:00:00");
        }

        [Test]

        public void clockIncrementAddsOne()
        {
            Clock test_clock = new Clock();

            test_clock.Tick();

            Assert.That(test_clock.Time == "00:00:01");
        }

        [Test]

        public void clockMultipleIncrementsWork()
        {

            Clock test_clock = new Clock();

            for (int i = 0; i < 115; i++)
            {
                test_clock.Tick();
            }

            Assert.That(test_clock.Time == "00:01:55");
        }

        [Test]

        public void clockResetWorks()
        {
            Clock test_clock = new Clock();

            for (int i = 0; i < 115; i++)
            {
                test_clock.Tick();
            }

            test_clock.Reset();

            Assert.That(test_clock.Time == "00:00:00");
        }

    }
}