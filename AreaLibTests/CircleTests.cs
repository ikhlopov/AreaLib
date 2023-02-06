using AreaLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaLibTests
{
    class CircleTests
    {
        [Test]
        public void Circle_Init_NegativeIn_returnExeption()
        {
            //arrange
            int r = -6;

            //act
            try
            {
                Circle fig = new Circle(r);
            }

            //assert
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }
            Assert.True(false, "No exeption");
        }

        [Test]
        public void Circle_Area_1In_returnPi()
        {
            //arrange
            int r = 1;
            double expected = Math.PI;

            //act
            Circle fig = new Circle(r);
            double actual = fig.Area;
            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}
