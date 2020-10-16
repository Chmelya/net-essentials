using System;
using FiguresLibrary;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
			IShapeAreaCalculator areaCalculator = new ShapeAreaCalculator();

			var shapes = new List<Shape>
			{
				new Triangle(4, 3),      // area = 6
				new Circle(2),           // area = pi
				new Rectangle(3, 2)    // area = 6
			};

			areaCalculator.Calculate(shapes); // 22.5663706

			Console.WriteLine(shapes[1].Name); // Circle
		}
    }
}
