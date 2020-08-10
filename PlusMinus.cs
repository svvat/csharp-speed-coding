using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace hr1
{
    public class PlusMinus
    {
        /// <summary>
        ///  https://www.hackerrank.com/challenges/plus-minus/problem
        ///  proportion of positive values
        ///  proportion of negative values
        ///  proportion of zeros
        /// </summary>
        /// <param name="arr"></param>
        public static void plusMinus(int[] arr)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int [] totals = { 0, 0, 0 };
            Array.ForEach(arr, element => {
                if (element > 0)
                    totals[0] ++;
                else if (element < 0)
                    totals[1] ++;
                else
                    totals[2] ++;
            });

            double grandTotal = arr.Length;
            Array.ForEach(totals, total =>
            {
                Console.WriteLine(String.Format("{0:0.000000}", (double)total / grandTotal));
            });
            //    foreach (var total in totals)
            //{
            //    double proportion = (double)total / grandTotal;
            //    Console.WriteLine(String.Format("{0:0.000000}", proportion));
            //}

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
