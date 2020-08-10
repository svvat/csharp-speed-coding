using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace hr1.Clouds
{
    public class Clouds
    {
        /// <summary>
        ///  https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        // Complete the jumpingOnClouds function below.

        public static int jumpingOnClouds(int[] c)
        {
            Trace.WriteLine(String.Format("{0} Clouds", c.Length));
            int steps = 0;
            int dStep = 0;
            for (int n = 1; n < c.Length; n++) 
            {
                if(c[n] == 1)
                {
                    if(dStep == 1)
                    {
                        steps++;
                        Trace.Write(" - STEP\n");
                    }
                    dStep = 1;
                    Trace.WriteLine(String.Format("Cloud[{0}] - THUNDER", n));
                }
                else
                {
                    Trace.Write(String.Format("Cloud[{0}]", n));
                    dStep++;
                    if(n==c.Length-1 || dStep > 1)
                    {
                        Trace.Write(" - STEP\n");
                        dStep = 0;
                        steps++;
                    }
                }
            }
            return steps;
        }

        public static void main()
        {
            string s = "0 0 0 1 0 0";
            int n = (s.Length+1)/2;
            int[] c = Array.ConvertAll(s.Split(' '), cTemp => Convert.ToInt32(cTemp)) ;
            int result = jumpingOnClouds(c);

            Trace.WriteLine(result);
        }
    }
}
