using System.Collections.Generic;

namespace FiguresLibrary
{
    public interface IShapeAreaCalculator
    {
        double Calculate(IEnumerable<Shape> shapes); // returns a sum of all shapes areas
    }
}
