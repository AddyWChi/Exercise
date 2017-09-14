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
            int[] list;
            FindHighFrequencyNumber num = new FindHighFrequencyNumber();

            list = new int[] { 1, 1, 2, 3, 4, 5 };
            Console.WriteLine("Expect 1.  Got: " + num.GetNumber(list));
            Console.WriteLine("Expect 1 (Linq).  Got: " + num.GetNumberQ(list));

            list = new int[] { 7, 7, 7, 1, 1, 2, 3, 4, 5 };
            Console.WriteLine("Expect 7.  Got: " + num.GetNumber(list));
            Console.WriteLine("Expect 7 (Linq).  Got: " + num.GetNumberQ(list));

            return;
        }
    }

    /// <summary>
    /// Given an unsorted array which has a number in the majority (a number appears more than 50% 
    /// in the array), find that number.
    /// </summary>
    public class FindHighFrequencyNumber
    {
        public FindHighFrequencyNumber()
        {
            return;
        }

        /// <summary>
        /// Get the number that appear most.
        /// </summary>
        /// <param name="list">A list of unsorted number.</param>
        /// <returns>A number that appears more than 50% of time.</returns>
        public int? GetNumber(params int[] list)
        {
            if (list.Length == 0)
            {
                return null;
            }

            Dictionary<int, int> log = new Dictionary<int, int>();

            int? number = null;
            int count = 0;
            foreach (int i in list)
            {
                if (log.ContainsKey(i) == false)
                {
                    log.Add(i, 1);
                    if (count < 1)
                    {
                        number = i;
                        count = 1;
                    }
                }
                else
                {
                    log[i] = log[i] + 1;
                    if (log[i] > count)
                    {
                        number = i;
                        count = log[i];
                    }
                }
            }

            return number;
        }

        /// <summary>
        /// Get the number that appear most using Linq.
        /// </summary>
        /// <param name="list">A list of unsorted number.</param>
        /// <returns>A number that appears more than 50% of time.</returns>
        public int? GetNumberQ(params int[] list)
        {
            if (list.Length == 0)
            {
                return null;
            }

            var num = list.GroupBy(n => n)
                        .OrderByDescending(s => s.Count())
                        .First().Key;

            return num;
        }
    }
}
