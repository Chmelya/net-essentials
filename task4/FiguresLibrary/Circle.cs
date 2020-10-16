using System;

namespace FiguresLibrary
{
    public class Circle: Shape
    {
        public double diameter { get; }
        public Circle(double diameter) : base("Circle")
        {
            this.diameter = diameter;
        }

        public override double GetArea()
        {
            return Math.PI * (diameter / 2) * (diameter / 2);
        }
    }
}
