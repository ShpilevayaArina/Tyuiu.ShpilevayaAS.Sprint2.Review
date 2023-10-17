using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShpilevayaAS.Sprint2.TaskReview.V11.Lib;

namespace Tyuiu.ShpilevayaAS.Sprint2.TaskReview.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTestMethod1CheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.1;
            double y = 0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
