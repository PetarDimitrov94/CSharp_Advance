namespace Task3
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        { 
            Radius = radius;
        }

        public override double CalculateArea()
        { 
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimetar()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
