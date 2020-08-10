using System;
using System.Collections.Generic;
using System.Text;

namespace hr1
{
    public class AVeryBigSum
    {
        public static long aVeryBigSum(long[] ar)
        {
            long total = 0;
            foreach(var i in ar)
            {
                total += i;
            }
            return total;
        }
    }
}
