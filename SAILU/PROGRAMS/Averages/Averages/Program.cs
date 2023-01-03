using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Average();
            //Minimum();
            //Maximum();
            MinimumMaximum();
            //CopyFromOneArrayToAnother();
            Console.Read();
        }

        static void Average()
        {
            int[] Temperatures = { 21, 22, 31, 42, 35, 26, 37, 28, 39, 40, 31, 42, 23, 34, 45, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int Sum = 0;

            for (int Count = 0; Count < Temperatures.Length; Count++)
            {
                Sum = Sum + Temperatures[Count];
            }

            int Average = Sum / Temperatures.Length;

            Console.WriteLine("Sum of {0} Days Temperature is : {1} and Their Average is : {2}",
                Temperatures.Length, Sum, Average);
        }

        static void Minimum()
        {
            int[] Temperatures = { 21, 22, 31, 42, 35, 26, 37, 28, 39, 40, 31, 42, 23, 34, 45, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int Min = Temperatures [0];

            for (int Count = 1; Count < Temperatures.Length; Count++)
            {
                if (Temperatures[Count] < Min)
                {
                    Min = Temperatures[Count];
                }
            }

            Console.WriteLine("Minimum of {0} Days Temperature is : {1}", Temperatures.Length, Min);
        }

        static void Maximum()
        {
            int[] Temperatures = { 21, 22, 31, 42, 35, 26, 37, 28, 39, 40, 31, 42, 23, 34, 45, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int Max = Temperatures[0];

            for (int Count = 1; Count < Temperatures.Length; Count++)
            {
                if (Temperatures[Count] > Max)
                {
                    Max = Temperatures[Count];
                }
            }

            Console.WriteLine("Maximum of {0} Days Temperature is : {1}", Temperatures.Length, Max);
        }

        static void MinimumMaximum()
        {
            int[] Temperatures = { 21, 22, 31, 42, 35, 26, 37, 28, 39, 40, 31, 42, 23, 34, 45, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int Max = Temperatures[0];
            int Min = Temperatures[0];

            for (int Count = 1; Count < Temperatures.Length; Count++)
            {
                if (Temperatures[Count] > Max)
                {
                    Max = Temperatures[Count];
                }
                if (Temperatures[Count] < Min)
                {
                    Min = Temperatures[Count];
                }
            }

            Console.WriteLine("Maximum of {0} Days Temperature is : {1} and Minimum is : {2} ", Temperatures.Length, Max,Min);
        }

        static void CopyFromOneArrayToAnother()
        {
            int[] Temperatures = { 21, 22, 31, 42, 35, 26, 37, 28, 39, 40, 31, 42, 23, 34, 45, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int[] NewTemperatures = new int[Temperatures.Length];

            for (int Count = 0; Count < Temperatures.Length; Count++)
            {
                NewTemperatures[Count] = Temperatures[Count];
                Console.WriteLine("New Temperatue on Day {0}  is : {1}", Count, NewTemperatures[Count]);
            }
        }
    }
}
    