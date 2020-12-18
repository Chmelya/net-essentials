using NUnit.Framework;
using FiguresLibrary;
using System.Collections.Generic;
using System;

namespace FiguresLibrary.Tests
{
    public class ShapesNameTests
    {
        private static object[] shapesNameCases =
        {
            new object[] { new Triangle(1, 4), "Triangle" },
            new object[] { new Rectangle(4, 5), "Rectangle" },
            new object[] { new Circle(2), "Circle" }
        };

        [TestCaseSource("shapesNameCases")]
        public void GetName_ProvidedDefferentShapeTypes_ReturnsCorrectName(Shape shape, string expectedName)
        {
            Assert.AreEqual(expectedName, shape.Name);
        }
    }
}