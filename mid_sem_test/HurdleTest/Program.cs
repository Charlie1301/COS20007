using System;

namespace HurdleTest
{
    public class Program
    {
        public static void Main()
        {

            List<int> num_list = new List<int>() { 1, 0, 3, 9, 8, 2, 4, 5, 7};


            DataAnalyser dataAnalyser = new DataAnalyser(num_list, new MinMaxSummary());

            dataAnalyser.Summarise();

            dataAnalyser.AddNumber(1);
            dataAnalyser.AddNumber(3);
            dataAnalyser.AddNumber(6);

            dataAnalyser.SummaryStrategy = new AverageSummary();

            dataAnalyser.Summarise();

        }
    }
}
