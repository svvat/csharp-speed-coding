using System;
using System.Collections.Generic;
using System.Linq;

namespace hr1
{
    public class BirthdayCakeCandles
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/birthday-cake-candles/problem
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int birthdayCakeCandles(int[] ar)
        {
            var arr = new List<int>(ar);
            // get highest number
            int mx = arr.Max();
            // count the instance of the highest number
            return ar.Where(value => value.Equals(mx)).Count();
        }
    }
}
