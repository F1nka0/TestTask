using System;
using System.Linq;
using System.Collections.Generic;
namespace TestTask
{
    public class Triangle : IFigure {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public Triangle(double SideA, double SideB, double SideC)
        {
            if (!IsValid(SideA, SideB, SideC)) {
                throw new Exception("Triangle is invalid");
            }
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }
        private bool IsValid(double SideA, double SideB, double SideC) {
            return ((SideA+SideB>SideC) && (SideA+SideC>SideB) && (SideB+SideC>SideA));
        }
        private double CalculatePerimeter() {
            return SideA + SideB + SideC;
        }
        public double CalculateArea() {
            double HalfPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - SideA) * (HalfPerimeter - SideB) * (HalfPerimeter - SideC));
        }
        public bool IsStraight() {
            List<double> Sides = new List<double>(new double[] {SideA,SideB,SideC});
            Sides.Sort();
            Sides.Reverse();
            return Math.Pow(Sides[0], 2) == Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2);
        }
    }
}
