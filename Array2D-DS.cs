using System;
using System.Collections.Generic;
using System.Text;

namespace hr1
{
    public class Array2D_DS
    {
        public static int hourglassSum(int[][] arr)
        {
            int? max=null;
            int nV = arr.Length - 2;
            int nH = arr[0].Length - 2;
            for (int ROW=0;ROW<nV;ROW++)
            {
                for (int COL = 0; COL < nH; COL++)
                {
                    int total = 0;
                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            if (row!=1 || (row== 1 && col==1))
                            {
                                total += arr[ROW + row][COL + col];
                            }
                        }
                    }
                    if(max==null || total > max) {
                        max = total;
                    }
                }
            }

            return max??0;

        }

    }
}
