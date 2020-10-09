﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresLibrary
{
    public class Triangle: Shape
    {
        double a;
        double h;
        public Triangle(double a, double h) : base("Triangle")
        {
            this.a = a;
            this.h = h;
        }

        public override double GetArea()
        {
            return 0.5 * a * h;
        }
    }
}
