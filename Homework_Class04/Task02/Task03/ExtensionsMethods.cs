using Task02.Models;

namespace Task02.Task03
{
    public static class ExtensionsMethods
    {
        public static void Drive(this Car car)
        {
            Console.WriteLine("The car is driving");
        }

        public static void Wheelie(this MotorBike motorbike)
        {
            Console.WriteLine("The motorbike is driving on one wheel");
        }

        public static void Sail(this Boat boat)
        {
            Console.WriteLine("The boat is sailing");
        }

        public static void Fly(this Airplane airplane)
        {
            Console.WriteLine("The airplane is flying");
        }
    }
}
