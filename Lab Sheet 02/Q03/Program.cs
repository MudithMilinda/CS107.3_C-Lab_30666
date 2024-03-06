using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03
{
    class TemperatureTracker
    {
        private double[] dailyTemperatures;
        
        public TemperatureTracker()
        {
            dailyTemperatures = new double[7];
        }

        public void InputTemperatures()
        {
            for (int i = 0; i < dailyTemperatures.Length; i++)
            {
                Console.WriteLine($"Enter temperature for day {i + 1}: ");
                double temperture = Convert.ToDouble(Console.ReadLine());
                dailyTemperatures[i] = temperture;
            }
        }

        public void WeeklyTemperature()
        {
            Console.WriteLine("Weekly Temperatures: ");
            for (int i = 0; i < dailyTemperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {dailyTemperatures[i]}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker();
            tracker.InputTemperatures();
            tracker.WeeklyTemperature();

            Console.ReadLine();
        }
    }
}
