//Task 1
//Create class PrintInConsole that will have multiple methods to print in console: Print(), PrintCollection().
//Make these methods to be valid for more than one type and use them accordingly with different types.

using Task01;

public class Program
{
    public static void Main()
    {
        PrintInConsole printInConsole = new PrintInConsole();

        printInConsole.Print("Hello, let's do it!");
        printInConsole.Print(10);
        printInConsole.Print(10.10);

        printInConsole.PrintCollections(new List<int> { 1, 2, 3, 4, 5 });
        printInConsole.PrintCollections(new List<string> { "Forza", "Inter", "Sempre" });


        Console.ReadLine();
    }

}