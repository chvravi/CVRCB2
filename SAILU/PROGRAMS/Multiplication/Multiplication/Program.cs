using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable Declaration
            int x = 20;
            int y = 5;
            int addition = 0, substraction = 0, multiplication = 0, division = 0;

            // Execution
            addition = Add(x, y);
            substraction = Subtract(x, y);
            multiplication = Multiply(x, y);
            division = Divide(x, y);

            Console.WriteLine(" The Addition value is : {0}", addition);
            Console.WriteLine(" The Subtraction value is : {0}", substraction);
            Console.WriteLine(" The Multiplication value is : {0}", multiplication);
            Console.WriteLine(" The Division value is : {0}", division);
            Console.Read();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
