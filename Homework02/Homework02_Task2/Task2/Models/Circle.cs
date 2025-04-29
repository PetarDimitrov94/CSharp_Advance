using Task2.Interface;

namespace Task2.Models
{
    public class Circle : IShape
    {
        public double Radius  { get; set; }
        public Circle(double radius)
        {
            Radius = radius;        
        }

        public double GetArea()
        { 
            return Math.PI * Radius * Radius;
        }
    }
}
