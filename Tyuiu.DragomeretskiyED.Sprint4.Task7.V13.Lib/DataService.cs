using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DragomeretskiyED.Sprint4.Task7.V13.Lib
{
    public class DataService : ISprint4Task7V13
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] da = new int[n, m];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    da[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }

            int con = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (da[i, j] % 2 == 0)
                    {
                        con++;
                    }
                }
            }

            return con;
        }
    }
}
