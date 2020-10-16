﻿using System.Collections.Generic;

namespace FiguresLibrary
{
    public class ShapeAreaCalculator : IShapeAreaCalculator
    {
        public double Calculate(IEnumerable<Shape> shapes)
        {
            double result = 0;
            foreach (var s in shapes)
            {
                result += s.GetArea();
            }
            return result;
        }
    }
}
