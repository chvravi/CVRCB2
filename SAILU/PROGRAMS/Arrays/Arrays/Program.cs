using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        /// <summary>
        /// This is the Starting point of Program. 
        /// Execution starts from this method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            squares();
            Console.Read();
        }


        static void squares()
        {
            int[] squares = new int[10];
            for (int i = 1; i < 11; i++)
            {
                squares[i-1] = i * i;
                Console.WriteLine("The Square of {0} is {1}",i,squares[i-1]);
            }
        }

    }
}
