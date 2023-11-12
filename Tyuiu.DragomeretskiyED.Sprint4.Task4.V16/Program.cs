using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DragomeretskiyED.Sprint4.Task4.V16.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint4.Task4.V16
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.Title = "Спринт #4 │ Выполнил: Драгомерецкий Е.Д. │ СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Драгомерецкий Егор Дмитриевич │ СМАРТб-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить четные значения в массиве                                      *");
            Console.WriteLine("* на цифру 1                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" 6, 5, 6, 7, 3,                                                           *");
            Console.WriteLine(" 5, 4, 6, 7, 3,                                                           *");
            Console.WriteLine(" 5, 5, 5, 6, 5,                                                           *");
            Console.WriteLine(" 6, 5, 4, 4, 3,                                                           *");
            Console.WriteLine(" 4, 5, 4, 5, 5,                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            int[,] res = new int[,] { { 6, 5, 6, 7, 3 },
                                      { 5, 4, 6, 7, 3 },
                                      { 5, 5, 5, 6, 5 },
                                      { 6, 5, 4, 4, 3 },
                                      { 4, 5, 4, 5, 5 } };

            var array = ds.Calculate(res);

            int rows = array.GetUpperBound(0) + 1;

            int columns = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0}\t", array[i, j]);

                }
            }
            Console.ReadKey();

        }
    }
}
