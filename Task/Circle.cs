using System;
namespace TestTask
{
    public class Circle : IFigure{
        public double Radius { get; }
        public Circle(double Radius) {
        //instance of Circle is crated if only it passes the validation
            this.Radius = Radius;
            if (!IsValid()) {
                throw new Exception("Circle is ");
            }
        }
        private bool IsValid() { 
            //in order for the circle to be valid it has to have it's radius bigger or equal to 0.
            return Radius >= 0;
        }
        public double CalculateArea() {
            //the formula of circle's area is pi*radius^2
            return Math.PI*Math.Pow(Radius,2);
        }
    }
}
