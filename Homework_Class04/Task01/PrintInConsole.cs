
namespace Task01
{
    internal class PrintInConsole
    {
        public void Print<T>(T item)
        {
        Console.WriteLine($"Print: {item}");
        }


        public void PrintCollections<T>(List<T> collections)
        {
            foreach (T item in collections)
            {
            Console.WriteLine(item);
            }
        }
    }
}
