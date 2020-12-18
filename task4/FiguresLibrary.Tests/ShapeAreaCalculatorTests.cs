using NUnit.Framework;
using FiguresLibrary;
using System.Collections.Generic;
using System;

namespace FiguresLibrary.Tests
{
    class ShapeAreaCalculatorTests
    {
        private IShapeAreaCalculator areaCalculator;

        [SetUp]
        public void Setup()
        {
            areaCalculator = new ShapeAreaCalculator();
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
