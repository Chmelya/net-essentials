using NUnit.Framework;
using FiguresLibrary;
using System.Collections.Generic;

namespace FiguresLibrary.Tests
{
    public class Tests
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
        public void triangleName(double side, double height)
        {
            triangle = new Triangle(side, height);

            Assert.AreEqual("Triangle", triangle.Name);
        }

        [TestCase(2)]
        [TestCase(4)]
        public void circleName(double diamter)
        {
           circle = new Circle(diamter);

            Assert.AreEqual("Circle", circle.Name);
        }

        [TestCase(2, 4)]
        [TestCase(4, 5)]
        public void reactangleName(double side, double height)
        {
            rectangle = new Rectangle(side, height);

            Assert.AreEqual("Rectangle", rectangle.Name);
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

            var areaSum = triangle.GetArea() + circle.GetArea() + rectangle.GetArea();
            
            Assert.AreEqual(areaSum, areaCalculator.Calculate(shapes));
        }
    }
}