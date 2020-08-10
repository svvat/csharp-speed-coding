using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace hr1
{
    public class EqualizeArray
    {
        /*
         * Complete the equalizeArray function in the editor below. It must return an integer that denotes the minimum number of deletions required.
            equalizeArray has the following parameter(s):
            arr: an array of integers

            https://www.hackerrank.com/challenges/equality-in-a-array/problem
        */

        public static int equalizeArray(int[] arr)
        {
            Dictionary<int, int> sizes = new Dictionary<int, int>();
            // find biggest set
            for(int n=0; n<arr.Length;n++)
            {
                int value = arr[n];
                if (!sizes.ContainsKey(value)) {
                    sizes.Add(value, 1);
                } else
                {
                    sizes[value]++;
                }
            }
            int biggest = 0;
            int bigKey = -1;
            foreach (var item in sizes)
            {
                if (item.Value > biggest)
                {
                    biggest = item.Value;
                    bigKey = item.Key;
                }
            }
            int deletions = 0;
            // delete all but bigKey
            for (int n = 0; n < arr.Length; n++)
            {
                int value = arr[n];
                if (value != bigKey) deletions++;
            }
            return deletions;

        }

        static void main()
        {
            string s = "3 3 2 1 3";

            int[] arr = Array.ConvertAll(s.Split(' '), cTemp => Convert.ToInt32(cTemp));
            
            int result = equalizeArray(arr);

            Trace.WriteLine(result);
        }
    }
}
