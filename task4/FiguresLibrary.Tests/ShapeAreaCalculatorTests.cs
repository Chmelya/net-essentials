using NUnit.Framework;
using FiguresLibrary;
using System.Collections.Generic;

namespace FiguresLibrary.Tests
{
    class ShapeAreaCalculatorTests
    {
        private IShapeAreaCalculator areaCalculator;
        Triangle triangle;
        Rectangle rectangle;
        Circle circle;

        [SetUp]
        public void Setup()
        {
            areaCalculator = new ShapeAreaCalculator();
        }

        [TestCase(2, 4)]
        [TestCase(4, 5)]
        public void triangleArea(double side, double height)
        {
            triangle = new Triangle(side, height);

            var testValue = 0.5 * side * height;

            Assert.AreEqual(testValue, triangle.GetArea());
        }

        [TestCase(4, 2)]
        [TestCase(5, 6)]
        public void rectangleArea(double side, double height)
        {
            rectangle = new Rectangle(side, height);

            var testValue = side * height;

            Assert.AreEqual(testValue, rectangle.GetArea());
        }

        [TestCase(4)]
        [TestCase(5)]
        public void circleleArea(double diameter)
        {
            circle = new Circle(diameter);

            var testValue = System.Math.PI * (diameter / 2) * (diameter / 2); ;

            Assert.AreEqual(testValue, circle.GetArea());
        }

        [Test]
        public void calculateArea()
        {
            triangle = new Triangle(4, 3);
            circle = new Circle(2);
            rectangle = new Rectangle(3, 2);

            var shapes = new List<Shape>
            {
                triangle,
                circle,
                rectangle
            };

            Assert.AreEqual(12 + System.Math.PI, areaCalculator.Calculate(shapes));
        }
    }
}
