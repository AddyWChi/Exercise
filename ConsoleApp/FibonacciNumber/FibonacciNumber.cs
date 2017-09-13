using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyMinutes.ConsoleApp
{
    class RunMain
    {
        static void Main(string[] args)
        {
            FibonacciNumber fn = new FibonacciNumber();
            Console.Write(fn.GetNumber(1) + " ");
            Console.Write(fn.GetNumber(2) + " ");
            Console.Write(fn.GetNumber(3) + " ");
            Console.Write(fn.GetNumber(4) + " ");
            Console.Write(fn.GetNumber(5) + " ");
            Console.Write(fn.GetNumber(6) + " ");
            Console.Write(fn.GetNumber(7) + " ");
            Console.Write(fn.GetNumber(8) + " ");

            return;
        }
    }

    public class FibonacciNumber
    {
        public FibonacciNumber()
        {
            return;
        }

        /// <summary>
        /// Get the Fibonacci number at the index.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Fibonacci number</returns>
        public int GetNumber(int index)
        {
            if (index <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index == 1 || index == 2)
            {
                return 1;
            }

            if (index == 3)
            {
                return 2;
            }

            int a = 1;
            int b = 1;
            int c = 2;

            for (int i = 4; i <= index; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }

            return c;
        }
    }
}
