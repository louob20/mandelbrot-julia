﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mandelbrot
{
    public class Complex
    {
        public double a; // real
        public double b; // imaginary

        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Square()
        {
            double temp = (a * a) - (b * b);
            b = 2.0 * a * b;
            a = temp;
        }

        public double Magnitude()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        public void Add(Complex c)
        {
            a += c.a;
            b += c.b;
        }
    }
}
