namespace Task3
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Height { get; set; }

        public Triangle(double a, double b, double c, double height)
        {
            SideA = a;
            SideB = b;
            SideC = c;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * SideA * Height;
        }

        public override double CalculatePerimetar()
        {
            return SideA + SideB + SideC;
        }

    }
}
