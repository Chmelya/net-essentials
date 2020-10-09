using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public class Circle: Shape
    {
        double d;
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
