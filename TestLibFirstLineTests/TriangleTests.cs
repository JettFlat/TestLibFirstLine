using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibFirstLine;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestLibFirstLine.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetTriagTypeTest_21_21_29p7_right_returned()
        {
            double a = 29.7;
            double b = 21;
            double c = 21;
            Triangle.TriagType expected = Triangle.TriagType.Right;
            Triangle.TriagType actual = Triangle.GetTriagType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetTriagTypeTest_3_4_5_right_returned()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle.TriagType expected = Triangle.TriagType.Right;
            Triangle.TriagType actual = Triangle.GetTriagType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetTriagTypeTest_8p97_10_7p32_AcuteAngled_returned()
        {
            double a = 8.97;
            double b = 10;
            double c = 7.32;
            Triangle.TriagType expected = Triangle.TriagType.AcuteAngled;
            Triangle.TriagType actual = Triangle.GetTriagType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetTriagTypeTest_10_4p62_12p94_Obtuse_returned()
        {
            double a = 10;
            double b = 4.62;
            double c = 12.94;
            Triangle.TriagType expected = Triangle.TriagType.Obtuse;
            Triangle.TriagType actual = Triangle.GetTriagType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetTriagTypeTest_5_5_20_NotTriangle_returned()
        {
            double a = 5;
            double b = 5;
            double c = 20;
            Triangle.TriagType expected = Triangle.TriagType.NotTriangle;
            Triangle.TriagType actual = Triangle.GetTriagType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}