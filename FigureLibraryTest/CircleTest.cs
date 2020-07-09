using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figure;
using System;

namespace FigureTest
{
    [TestClass]
    public class CircleTest
    {
         [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void zeroLengthRadius()
        {
            var circle = new Circle(0.0);
            var area = circle.Area;
        }

        [TestMethod]
        public void validRadius()
        {
            var circle = new Circle(4.0);
            var area = circle.Area;
            Assert.AreEqual(area, 4 * 4 * Math.PI);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void negativeRadius()
        {
            var circle = new Circle(-10.0);
            var area = circle.Area;
        }

        [TestMethod]
        public void maxDoubleArea()
        {
            var circle = new Circle(double.MaxValue / 2);
            var area = circle.Area;
            Assert.AreEqual(area, double.PositiveInfinity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void infiniteRadius()
        {
            var circle = new Circle(double.PositiveInfinity);
            var area = circle.Area;
        }
    }
}
