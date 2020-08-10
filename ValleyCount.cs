using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace hr1
{
    public class ValleyCount
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int height = 0;
            int oldHeight = 0;
            int valleyCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'D') height--;
                if (s[i] == 'U') height++;
                if (oldHeight == 0 && height < 0) valleyCount++;
                oldHeight = height;

            }
            return valleyCount;
        }
        public static void main()
        {
            Console.WriteLine("Hello World!");

            string s = "UDDDUDUU";// Console.ReadLine();



            int n = s.Length;


            int result = countingValleys(n, s);

            Debug.WriteLine(result);
        }
    }
}
