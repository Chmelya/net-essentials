using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public class Rectangle: Shape
    {
        public double a { get; }
        public double b { get; }
        public Rectangle(double a, double b) : base("Rectangle")
        {
            this.a = a;
            this.b = b;
        }

        public override double GetArea()
        {
            return a * b;
        }
    }
}
