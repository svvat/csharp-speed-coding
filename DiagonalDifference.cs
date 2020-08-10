using System;
using System.Collections.Generic;
using System.Text;

namespace hr1
{
    public class DiagonalDifference
    {
        /*
         * https://www.hackerrank.com/challenges/diagonal-difference/problem
 * The function is expected to return an INTEGER.
 * The function accepts 2D_INTEGER_ARRAY arr as parameter.
 */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int p1 = arr.Count-1;
            int p2 = 0;
            int total1 = 0;
            int total2 = 0;
            foreach (var row in arr)
            {
                total1 += row[p1];
                total2 += row[p2];
                p1--;
                p2++;
            }


            return Math.Abs(total1-total2) ;
        }
    }
}
