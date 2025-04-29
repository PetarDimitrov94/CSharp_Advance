// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using Task4;

//Task 4:
//Write a program to create an abstract class Employee with abstract methods CalculateSalary() and DisplayInfo(). 
//Create subclasses Manager and Programmer that extend the Employee class and implement the respective methods to calculate salary and display information for each role.


public class Program
{
    public static void Main()
    {
        Manager manager = new Manager("Bob", 5000);
        Programmer programmer = new Programmer("Petar", 30, 168);

        manager.DisplayInfo();
        Console.WriteLine();
        programmer.DisplayInfo();
    }
}