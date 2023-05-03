using System;

namespace HurdleTest
{
    public class AverageSummary : SummaryStrategy
    {

        private float Average(List<int> numbers) {

            float sum = 0;

            foreach (int value in numbers) { sum += value; }

            return (sum / (float)numbers.Count);
        
        }

        public override void PrintSummary(List<int> numbers) {

            Console.WriteLine($"Average: {Average(numbers)}");
        
        }

    }
}
