﻿using Task2.Interface;

namespace Task2.Models
{
    public class Triangle : IShape
    {
        public double Base {  get; set; }
        public double Height { get; set; }

        public Triangle (double b, double h)
        {
            Base = b;
            Height = h;
        }

        public double GetArea()
        { 
            return 0.5 * Base * Height;
        }
    }
}
