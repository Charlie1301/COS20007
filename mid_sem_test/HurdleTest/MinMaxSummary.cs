using System;

namespace HurdleTest
{
    public class MinMaxSummary : SummaryStrategy
    {

        private int Maximum(List<int> numbers) {

            int max = numbers[0];

            foreach (int value in numbers)
            {
                if (value > max) { max = value; }
            }

            return max;

        }

        private int Minimum(List<int> numbers) { 
        
            int min = numbers[0];

            foreach (int value in numbers)
            {
                if (value < min) { min = value; }
            }

            return min;

        }

        public override void PrintSummary(List<int> numbers) 
        {

            Console.WriteLine($"Min: {Minimum(numbers)}");
            Console.WriteLine($"Max: {Maximum(numbers)}");
        
        }

    }
}
