using NUnit.Framework;
using FiguresLibrary;
using System.Collections.Generic;
using System;

namespace FiguresLibrary.Tests
{
    class ShapeAreaCalculatorTests
    {
        private IShapeAreaCalculator areaCalculator;

        private static object[] shapesGetAreaCases =
        {
            new object[] { new Triangle(2, 3), 3 },
            new object[] { new Triangle(4, 5), 10 },
            new object[] { new Rectangle(4, 2), 8 },
            new object[] { new Rectangle(5, 6), 30 },
            new object[] { new Circle(2), Math.PI }
        };

        [SetUp]
        public void Setup()
        {
            areaCalculator = new ShapeAreaCalculator();
        }

        [TestCaseSource("shapesGetAreaCases")]
        public void GetArea_ProvidedDifferentShapeTypes_ReturnsCorrectArea(Shape shape, double expectedArea)
        {
            Assert.AreEqual(expectedArea, shape.GetArea());
        }

        [Test]
        public void Calculate_MultipleShapesProvided_ReturnsCorrectArea()
        {
            
            var shapes = new List<Shape>
            { 
                new Triangle(4, 3),
                new Circle(2),
                new Rectangle(3, 2)
            };

            Assert.AreEqual(12 + System.Math.PI, areaCalculator.Calculate(shapes));
        }
    }
}
