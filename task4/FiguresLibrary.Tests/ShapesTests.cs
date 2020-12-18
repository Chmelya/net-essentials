using NUnit.Framework;
using FiguresLibrary;
using System.Collections.Generic;
using System;

namespace FiguresLibrary.Tests
{
    public class ShapesTests
    {
        private static object[] shapesGetAreaCases =
        {
            new object[] { new Triangle(2, 3), 3 },
            new object[] { new Triangle(4, 5), 10 },
            new object[] { new Rectangle(4, 2), 8 },
            new object[] { new Rectangle(5, 6), 30 },
            new object[] { new Circle(2), Math.PI }
        };

        private static object[] shapesNameCases =
        {
            new object[] { new Triangle(1, 4), "Triangle" },
            new object[] { new Rectangle(4, 5), "Rectangle" },
            new object[] { new Circle(2), "Circle" }
        };

        [TestCaseSource("shapesGetAreaCases")]
        public void GetArea_ProvidedDifferentShapeTypes_ReturnsCorrectArea(Shape shape, double expectedArea)
        {
            Assert.AreEqual(expectedArea, shape.GetArea());
        }

        [TestCaseSource("shapesNameCases")]
        public void GetName_ProvidedDefferentShapeTypes_ReturnsCorrectName(Shape shape, string expectedName)
        {
            Assert.AreEqual(expectedName, shape.Name);
        }
    }
}