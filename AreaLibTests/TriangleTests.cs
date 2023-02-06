using NUnit.Framework;
using AreaLib;
using System;

namespace AreaLibTests
{
    public class TriangleTests
    {

        [Test]
        public void Triangle_Area_3and4and5_return6()
        {
            //arrange
            int a = 3;
            int b = 4;
            int c = 5;
            int expected = 6;
            //act
            Triangle fig = new Triangle(a, b, c);
            int actual = (int)fig.Area;
            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Triangle_Init_1and2and13_returnExeption()
        {
            //arrange
            int a = 1;
            int b = 2;
            int c = 13;

            //act
            try 
            {
                Triangle fig = new Triangle(a, b, c);
            }
            catch (Exception)
            {
                Assert.Pass();
            }
            Assert.True(false,"No exeption");
        }

        [Test]
        public void Triangle_IsRectangle_3and4and5_returnTrue()
        {
            //arrange
            int a = 3;
            int b = 4;
            int c = 5;

            //act
            Triangle fig = new Triangle(c, b, a);
            bool result = fig.IsRectangle;

            //assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Triangle_Init_NegIn_returnException()
        {
            //arrange
            int a = -3;
            int b = 4;
            int c = 5;

            //act
            try
            {
                Triangle fig = new Triangle(c, b, a);
            }
            //assert
            catch (ArgumentOutOfRangeException)
            {
                Assert.Pass();
            }
            Assert.True(false, "No exeption");
        }
    }
}