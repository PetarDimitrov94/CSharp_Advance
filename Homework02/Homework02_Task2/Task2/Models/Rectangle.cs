using Task2.Interface;

namespace Task2.Models
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) 
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
            { return Width * Height; }
    }

}
