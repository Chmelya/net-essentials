using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public class Circle: Shape
    {
        public double d { get; }
        public Circle(double d) : base("Circle")
        {
            this.d = d;
        }

        public override double GetArea()
        {
            return Math.PI * (d / 2) * (d / 2);
        }
    }
}
