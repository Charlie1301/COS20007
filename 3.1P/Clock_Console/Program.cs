using System;
using CounterTask;
using Clock_Class;

namespace Clocks
{

    class MainClass
    {

        public static void Main(string[] args)
        {
            Clock main_clock = new Clock();

            for (int i = 0; i < 356; i++)
            {
                main_clock.Tick();
            }

            Console.WriteLine(main_clock.Time);
        }
    }
}