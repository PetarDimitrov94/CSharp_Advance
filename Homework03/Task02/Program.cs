
//## Task 2
//Create a class Vehicle that have one method DisplayInfo().
//Create class Car, MotorBike, Boat, Airplane that will inherit from Vehicle and will implement the respective method;

//```
//Vehicle car = new Car();
//Vehicle motorBike = new MotorBike();
//Vehicle boat = new Boat();
//Vehicle plane = new Airplane();

//car.DisplayInfo();
//motorBike.DisplayInfo();
//boat.DisplayInfo();
//plane.DisplayInfo()

//// in console we should display
//// Im a car and i drive on 4 wheels :)
//// Im a motorbike and i drive on 2 wheels :)
//// Im a boat and i do not have wheels :(
//// Im a plane i have couple of wheels :)
//```
using Task02;
using Task02.Models;
public class Program
{
    public static void Main()
    {
        Vehicle car = new Car();
        Vehicle motorBike = new MotorBike();
        Vehicle boat = new Boat();
        Vehicle plane = new Airplane();

        car.DisplayInfo();
        motorBike.DisplayInfo();
        boat.DisplayInfo();
        plane.DisplayInfo();


        Console.ReadLine();
    }
    
}