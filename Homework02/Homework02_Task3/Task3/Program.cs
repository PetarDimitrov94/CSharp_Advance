// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using Task3;

//Task 3:
//Write a program to create an abstract class Shape with abstract methods CalculateArea() and CalculatePerimeter().
//Create subclasses Circle and Triangle that extend the Shape class and implement the respective methods to calculate the area and perimeter of each shape.

public class Program
{
    public static void Main()
    {
        Circle circle = new Circle(5);
        Console.WriteLine("Circle Area: " + circle.CalculateArea());
        Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimetar());

        Triangle triangle = new Triangle(5, 6, 5, 4);
        Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
        Console.WriteLine("Triangle Perimeter: " + triangle.CalculatePerimetar());
    }
}

