using NUnit.Framework;
using FiguresLibrary;
using System.Collections.Generic;
using System;

namespace FiguresLibrary.Tests
{
    public class ShapesTests
    {
        private static readonly Shape item0 = new Triangle(1, 4);
        private static readonly Shape item1 = new Circle(2);
        private static readonly Shape item2 = new Rectangle(4, 5);

        private static Shape getObject(string key)
        {
            switch (key)
            {
                case "item0":
                    return item0;
                case "item1":
                    return item1;
                case "item2":
                    return item2;
            }
                

            throw new ArgumentException("Unknown key");
        }

        [TestCase("item0", "Triangle")]
        [TestCase("item1", "Circle")]
        [TestCase("item2", "Rectangle")]
        public void GetName_ProvidedDefferentShapeTypes_ReturnsCorrectName(string shape, string expectedName)
        {
            Shape figure = getObject(shape);
            Assert.AreEqual(expectedName, figure.Name);
        }
    }
}