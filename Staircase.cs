using System;
using System.Collections.Generic;
using System.Text;

namespace hr1
{
    public class Staircase
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/staircase/
        /// Print a staircase of size  using # symbols and spaces.
        /// </summary>
        /// <param name="n">A single integer, , denoting the size of the staircase.</param>
        public static void staircase(int n)
        {
            for(int i=0; i<n; i++)
            {
                int nSpace = (n-1) - i;
                string s = "".PadLeft(nSpace, ' ').PadRight(n, '#');
                Console.WriteLine(s);
            }

        }

    }
}
