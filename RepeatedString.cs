using System;
using System.Collections.Generic;
using System.Text;

namespace hr1
{
    public class RepeatedString
    {
        // Complete the repeatedString function below.
        public static long repeatedString(string s, long n)
        {
            var ss = s.Split('a');
            long sCount = ss.Length-1;

            int slen = s.Length;
            long total = (n / slen) * sCount;

            // get remainder
            long remainder = n % slen;
            string remString = s.Substring(0, (int)remainder);
            ss = remString.Split('a');
            total += ss.Length-1;

            return total;

        }
    }
}
