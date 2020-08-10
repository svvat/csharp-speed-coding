using System;
using System.Collections.Generic;
using System.Text;

namespace hr1
{
    public class GradingStudents
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/grading
        /// </summary>
        /// <param name="grades"></param>
        /// <returns></returns>
        public static List<int> gradingStudents(List<int> grades)
        {
            for(int i=0;i<grades.Count;i++)
            {
                int grade = grades[i];
                if (grade >= 38)
                {
                    int dif = (5-(grade % 5));
                    if (dif < 3)
                    {
                        grades[i] = grade + dif;
                    }
                }
            }
            return grades;
        }
    }
}
