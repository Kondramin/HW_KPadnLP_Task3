using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureLib;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FigureLib.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void AreaTest()
        {
            //arrange
            var quad = new Quadrangle(new Top(1, 1), new Top(1, 2), new Top(2, 2), new Top(2, 1), Color.White);
            int expected = 1;

            //act
            double actual = quad.Area();

            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void PerimeterTest()
        {
            //Arrange
            var quad = new Quadrangle(new Top(1, 1), new Top(1, 2), new Top(2, 2), new Top(2, 1), Color.White);
            int expected = 4;

            //act
            double actual = quad.Perimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SideLengthTest()
        {
            //Arrange
            var fig = new Triangle();
            fig.A = new Top(1, 1);
            fig.B = new Top(1, 2);
            int expected = 1;

            // Act
            var actual = fig.SideLength(fig.A, fig.B);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SecondQuarterChekTest()
        {
            //arrange
            var quad = new Quadrangle(new Top(1, 1), new Top(1, 2), new Top(2, 2), new Top(2, 1), Color.White);
            var ListFig = new List<Figure> { quad };
            Color expected = Color.White;

            //act
            quad.SecondQuarterChek(ListFig);
            Color actual = quad.ColorFigure;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SecondQuarterChekTest1()
        {
            //arrange
            var quad = new Quadrangle(new Top(1, -1), new Top(1, -2), new Top(2, -2), new Top(2, -1), Color.White);
            var ListFig = new List<Figure> { quad };
            Color expected = Color.Green;

            //act
            quad.SecondQuarterChek(ListFig);
            Color actual = quad.ColorFigure;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}