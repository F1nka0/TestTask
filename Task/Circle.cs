using System;
namespace TestTask
{
    public class Circle : IFigure{
        public double Radius { get; }
        public Circle(double Radius)
        {
            if (!IsValid(Radius)) {
                throw new Exception("Circle is ");
            }
            this.Radius = Radius;
        }
        private bool IsValid(double Radius) {
            return Radius >= 0;
        }
        public double CalculateArea() {
            return Math.PI*Math.Pow(Radius,2);
        }
    }
}
