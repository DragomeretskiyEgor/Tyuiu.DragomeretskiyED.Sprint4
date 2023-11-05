using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint4.Task2.V14.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint4.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };

            int res = ds.Calculate(numsArray);
            int wait = 295245;
            Assert.AreEqual(wait, res);
        }
    }
}
