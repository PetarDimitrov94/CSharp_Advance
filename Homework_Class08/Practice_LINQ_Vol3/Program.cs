using Practice_LINQ_Vol3.Models;
using System;

Console.WriteLine("==============================1=======================================");
//****Requirements
//1.Select the horsepower of US cars with more than 150 horsepower.

List<Car> horsepowerUsCars = CarsData.Cars
            .Where(c => c.Origin == "US" && c.HorsePower > 150)
            .OrderByDescending(c => c.HorsePower)
            .ToList();

foreach (Car hp in horsepowerUsCars)
{
    Console.WriteLine($"HorsePower {hp.Model} cars with {hp.HorsePower} horsepower");
}

Console.WriteLine("==============================2=======================================");

//2.Select the weight of European cars with less than 100 horsepower.
List<Car> weightOfEuropeanCars = CarsData.Cars
    .Where(c => c.Origin == "Europe" && c.HorsePower < 100)
    .ToList();

foreach (Car item in weightOfEuropeanCars)
{
    Console.WriteLine($"European cars weight:{item.Weight}");
}

Console.WriteLine("==============================3=======================================");

//3.Select the origin of Japanese cars that weigh less than 2200.
List<Car> japaneseCarLessThan2200weight = CarsData.Cars
    .Where (c => c.Origin == "Japan" && c.Weight < 2200)
    .ToList();

foreach (Car item in japaneseCarLessThan2200weight)
{
    Console.WriteLine($"{item.Origin} cars with {item.Weight} weight ");
}

Console.WriteLine("==============================4=======================================");

//4.Select the cylinder count of US cars with exactly 8 cylinders.
List<Car> cylinderCountOfUsCars = CarsData.Cars
    .Where (c => c.Origin == "US" && c.Cylinders == 8)
    .ToList ();

foreach (Car item in cylinderCountOfUsCars)
{
    Console.WriteLine($"{item.Origin} cars  with {item.Cylinders} cylinders");
}

Console.WriteLine("==============================5=======================================");

//5.Select the miles per gallon of cars with more than 25 miles per gallon and acceleration time over 15 seconds.
List<Car> fastCars = CarsData.Cars
    .Where (c => c.MilesPerGalon > 25 && c.AccelerationTime > 15)
    .ToList();

foreach (Car item in fastCars)
{
    Console.WriteLine($" Cars with {item.MilesPerGalon} miles per gallon and {item.AccelerationTime} acceleration time");
}

Console.WriteLine("==============================6=======================================");

//6.Get the acceleration time of the last 4-cylinder car with acceleration time less than 15 seconds.
 var accelerationTimeOfLast4CylinderCar = CarsData.Cars
    .Where(c => c.Cylinders == 4 && c.AccelerationTime < 15)
    .Select (c => c.AccelerationTime)
    .LastOrDefault();

Console.WriteLine(accelerationTimeOfLast4CylinderCar);

Console.WriteLine("==============================7=======================================");

//7.Get the model name of the first car that has 0 horsepower.
   Car carWith0Horsepower = CarsData.Cars
    .FirstOrDefault(c => c.HorsePower == 0);

Console.WriteLine($"Model: {carWith0Horsepower.Model}");

Console.WriteLine("==============================8=======================================");
//8.Get the weight of the last Japanese car with more than 90 horsepower.
Car japaneseCarWeight = CarsData.Cars
    .Where(c => c.Origin == "Japan" && c.HorsePower > 90)
    .FirstOrDefault();

Console.WriteLine($"Weight of the last Japanese car with more then 90 horsepower: {japaneseCarWeight.Weight}");

Console.WriteLine("==============================9=======================================");
//9.Get the horsepower of the first US car that weighs more than 4000 and has fewer than 6 cylinders.
Car usCarHorsepower = CarsData.Cars
    .FirstOrDefault(c => c.Origin == "US" && c.Weight > 4000 && c.Cylinders < 6);

Console.WriteLine($"US car with {usCarHorsepower.HorsePower} horsepower"); // nema vakva kola

Console.WriteLine("==============================10=======================================");
//10.Get the origin of the last car with acceleration time greater than 20 seconds.
Car originOfTheLasCar = CarsData.Cars
    .LastOrDefault(c => c.AccelerationTime > 20);

Console.WriteLine($"The last car with acceleration time greater than 20 seconds is from: {originOfTheLasCar.Origin}");



Console.ReadLine();