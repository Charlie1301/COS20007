using System;

namespace HurdleTest
{
    public class DataAnalyser
    {

        private List<int> _numbers;

        private SummaryStrategy _strategy;


        public DataAnalyser(List<int> numbers, SummaryStrategy strategy) { 
           
            _numbers = numbers; 
            _strategy = strategy;

        }

        public DataAnalyser() : this(new List<int> { }, new AverageSummary()) { }


        public SummaryStrategy SummaryStrategy { get { return _strategy; } set { _strategy = value; } }


        public void AddNumber(int num) { _numbers.Add(num); }

        public void Summarise() { _strategy.PrintSummary(_numbers); }

    }
}
