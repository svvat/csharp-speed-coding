using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace hr1
{
    public class QueenAttackII
    {
        // https://www.hackerrank.com/challenges/queens-attack-2

        public static int queensAttack(
            int n, // board size
            int k, // Number of obstacles
            int r_q, // queen row
            int c_q, // queen column
            int[][] obstacles)
        {
            var obstacleList = new HashSet<string>();
            foreach (var obstacle in obstacles)
            {
                obstacleList.Add(String.Format("{0} {1}", obstacle[0], obstacle[1]));
            }
            int nMove = 0;
            for (int dr = -1; dr < 2; dr += 1)
            {
                for (int dc = -1; dc < 2; dc += 1)
                {
                    if (dr != 0 || dc != 0)
                    {
                        int r = r_q + dr;
                        int c = c_q + dc;
                        while (r > 0 && r <= n && c > 0 && c <= n)
                        {
                            string s = String.Format("{0} {1}", r, c);
                            if (obstacleList.Contains(s))
                            {
                                break;
                            }
                            r += dr;
                            c += dc;
                            nMove++;
                        }
                    }

                }
            }
            return nMove;
        }
    }
}
