using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figure;
using System;

namespace FigureTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void zeroLengthSides()
        {
            var triangle = new Triangle(0.0, 0.0, 0.0);
            var area = triangle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void zeroLength1Side()
        {
            var triangle = new Triangle(0.0, 1.0, 2.0);
            var area = triangle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void zeroLength2Sides()
        {
            var triangle = new Triangle(0.0, 1.0, 0.0);
            var area = triangle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void negativeLengthSides()
        {
            var triangle = new Triangle(-14.0, -9.0, -6.0);
            var area = triangle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void negativeLength1Side()
        {
            var triangle = new Triangle(-14.0, 9.0, 6.0);
            var area = triangle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void negativeLength2Sides()
        {
            var triangle = new Triangle(-14.0, 9.0, -6.0);
            var area = triangle.Area;
        }

        [TestMethod]
        public void validTriangle()
        {
            var triangle = new Triangle(14.0, 9.0, 6.0);
            var area = triangle.Area;
            Assert.AreEqual(area, 18.41);
        }

        [TestMethod]
        public void maxDoubleArea()
        {
            var triangle = new Triangle(double.MaxValue / 3, double.MaxValue / 3, double.MaxValue / 3);
            var area = triangle.Area;
            Assert.AreEqual(area, double.PositiveInfinity);
        }

        [TestMethod]
        public void rectangularTriangle()
        {
            var triangle = new Triangle(3.0, 4.0, 5.0);
            var right = triangle.Rectangular;
            Assert.AreEqual(right, true);
        }

        [TestMethod]
        public void isNotReactangularTriangle()
        {
            var triangle = new Triangle(3.0, 4.0, 6.0);
            var right = triangle.Rectangular;
            Assert.AreEqual(right, false);
        }
    }
}
