using System;
using System.Collections.Generic;
using System.Text;

namespace hr1
{
    public class TimeConversion
    {
        /// <summary>
        /// Given a time in -hour AM/PM format, convert it to military (24-hour) time.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string timeConversion(string s)
        {
            DateTime dt = Convert.ToDateTime(s);
            return dt.ToString("HH:mm:ss");
        }
    }
}
