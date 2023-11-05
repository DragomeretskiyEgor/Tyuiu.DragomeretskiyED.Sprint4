using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.DragomeretskiyED.Sprint4.Task1.V21.Lib;

namespace Tyuiu.DragomeretskiyED.Sprint4.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check111()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };

            int res = ds.Calculate(array);
            int wait = 1769472;
            Assert.AreEqual(wait, res);
        }
    }
}
