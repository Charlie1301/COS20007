using System;
using CounterTask;

namespace Clock_Class
{

    public class Clock
    {

        private Counter _hours = new Counter("Hours");
        private Counter _minutes = new Counter("Minutes");
        private Counter _seconds = new Counter("Seconds");

        public void Tick()
        {

            _seconds.Increment();

            if (_seconds.Count == 60)
            {

                _seconds.Reset();

                _minutes.Increment();
            }

            if (_minutes.Count == 60)
            {

                _minutes.Reset();

                _hours.Increment();
            }

            if (_hours.Count == 24)
            {

                _hours.Reset();

            }
        }

        public void Reset()
        {

            _seconds.Reset();

            _minutes.Reset();

            _hours.Reset();
        }

        public string Time
        {

            get
            {
 
                return String.Format("{0:00}:{1:00}:{2:00}", _hours.Count, _minutes.Count, _seconds.Count);
            }
        }

    }

}