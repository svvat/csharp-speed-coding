using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hr1
{
    public class Mini_MaxSum
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/mini-max-sum
        /// Print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.
        /// ie print 2 sums, one without max, one without min
        /// </summary>
        /// <param name="arr"></param>
        public static void miniMaxSum(int[] arr)
        {
            Console.WriteLine(getMiniMaxSum(arr));
        }
        public static string getMiniMaxSum(int[] arr)
        {
            long total = 0;
            Array.ForEach(arr, value => total += value);
            long max = total - arr.Min();
            long min = total - arr.Max();
            return String.Format("{0} {1}", min, max);

        }

    }
}
