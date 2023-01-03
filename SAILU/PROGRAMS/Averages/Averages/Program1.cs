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
            Average();
            Minimum();
            Maximum();
            Console.Read();
        }

        static void Average()
        {
            int[] MathsMarks = { 90, 98, 94, 76, 82 };
            int Sum = 0;

            for (int Count = 0; Count < MathsMarks.Length; Count++)
            {
                Sum = Sum + MathsMarks[Count];
            }

            int Average = Sum / MathsMarks.Length;

            Console.WriteLine("Sum of {0} Students Marks is : {1} and Their Average is : {2}",
                MathsMarks.Length, Sum, Average);
        }

        static void Minimum()
        {
            int[] MathsMarks = { 90, 98, 94, 76, 82 };
            int Min = MathsMarks[0];

            for (int Count = 1; Count < MathsMarks.Length; Count++)
            {
                if (MathsMarks[Count] < Min)
                {
                    Min = MathsMarks[Count];
                }
            }

            Console.WriteLine("Minimum of {0} Students Marks is : {1}", MathsMarks.Length, Min);
        }

        static void Maximum()
        {
            int[] MathsMarks = { 90, 98, 94, 76, 82 };
            int Max = MathsMarks[0];

            for (int Count = 1; Count < MathsMarks.Length; Count++)
            {
                if (MathsMarks[Count] > Max)
                {
                    Max = MathsMarks[Count];
                }
            }

            Console.WriteLine("Maximum of {0} Students Marks is : {1}", MathsMarks.Length, Max);
        }
    }
}