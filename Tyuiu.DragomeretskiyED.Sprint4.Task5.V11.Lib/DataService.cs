using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.DragomeretskiyED.Sprint4.Task5.V11.Lib
{
    public class DataService : ISprint4Task5V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] res = matrix;
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    if (res[i, j] > 0)
                        res[i, j] = 1;
                }
            }
            return res;
        }
    }
}
