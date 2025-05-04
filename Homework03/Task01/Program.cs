//## Task 1

//Create class User that will have 3 properties Id, Name, Age.
//Create static class UserDatabase that will contain a list of Users (create couple of users and add them to the list).
//Create method (or methods) Search() that will search the UserDatabase by Id, Name and Age and will return users as a result. 


using Task01;

public class Program
{
    public static void Main()
    {
        var userById = UserDatabase.SearchById(2);
        Console.WriteLine($"User with ID 3: {userById.Name}, Age {userById.Age}");

        var usersByName = UserDatabase.SearchByName("Petar");
        Console.WriteLine("\nUsers named Petar:");
        foreach (var user in usersByName)
        {
            Console.WriteLine($"ID: {user.Id}, Age: {user.Age}");
        }

        var usersByAge = UserDatabase.SearchByAge(28);
        Console.WriteLine("\nUsers aged 28:");
        foreach (var user in usersByAge)
        {
            Console.WriteLine($"ID: {user.Id}, Name: {user.Name}");
        }

        Console.ReadLine();
    }
}