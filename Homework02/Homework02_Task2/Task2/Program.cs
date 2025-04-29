// See https://aka.ms/new-console-template for more information

//Task 2
//Write a program to create an interface Shape with the GetArea() method. 
//Create three classes Rectangle, Circle, and Triangle that implement the Shape interface. Implement the GetArea() method for each of the three classes.


using Task2.Models;

public class Program
{
    public static void Main()
    {
        Rectangle rect = new Rectangle(3, 2);
        Circle circle = new Circle(6);
        Triangle triangle = new Triangle(4, 2);

        Console.WriteLine("Rectangle Area: " + rect.GetArea());
        Console.WriteLine("Circle Area: " + circle.GetArea());
        Console.WriteLine("Triangle Area: " + triangle.GetArea());
    }
}