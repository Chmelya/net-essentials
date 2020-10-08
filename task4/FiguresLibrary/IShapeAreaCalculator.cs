using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public interface IShapeAreaCalculator
    {
        double Calculate(IEnumerable<Shape> shapes); // returns a sum of all shapes areas
    }

}
