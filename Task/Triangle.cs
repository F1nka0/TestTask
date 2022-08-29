using System;
using System.Linq;
using System.Collections.Generic;
namespace TestTask
{
    public class Triangle : IFigure {
        public double SideA { get; } // sides of a triangle
        public double SideB { get; }
        public double SideC { get; }
        public Triangle(double SideA, double SideB, double SideC) {
            //instance of Triangle is crated if only it passes the validation
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
            if (!IsValid()) { 
                throw new Exception("Triangle is invalid");
            }
        }
        private bool IsValid() { 
            /* in order for the triangle to be valid 
             the sum of any two of it's sides
             has to be greater than the third
             */
            return ((SideA+SideB>SideC) && (SideA+SideC>SideB) && (SideB+SideC>SideA));
        }
        private double CalculatePerimeter() {
            //sum of the length of each side
            return SideA + SideB + SideC;
        }
        public double CalculateArea()
        {
            // S = sqrt(p/2 * (p/2-a)* (p/2-b)* (p/2-c))
            double HalfPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - SideA) * (HalfPerimeter - SideB) * (HalfPerimeter - SideC));
        }
        public bool IsRight() {
            /*
             to figre out if the triangle is right
             the pythagorean theorem has to work for it
             so if a^2 = b^2+c^2 is true thst means than this triangle is right
             */
            List<double> Sides = new List<double>(new double[] {SideA,SideB,SideC});
            Sides.Sort();
            Sides.Reverse();
            return Math.Pow(Sides[0], 2) == Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2);
        }
    }
}
