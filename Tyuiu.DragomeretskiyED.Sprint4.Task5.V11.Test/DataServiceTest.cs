using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint4.Task5.V11.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_Test()
        {
            int[,] mtrx = new int[2, 2] { {-5, 2 },
                                          { 2, 1} };
            int[,] res = new int[2, 2] { {-5, 1 },
                                         { 1, 1} };
            DataService ds = new DataService();
            CollectionAssert.AreEqual(ds.Calculate(mtrx), res);
        }
    }
}
