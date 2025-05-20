namespace Homework_Class06
{
    public class ModelAndHorsepowerOfCar
    {
        public string Model { get; set; }
        public double HorsePower { get; set; }

        public void PrintInfo (List<ModelAndHorsepowerOfCar> list)
        {
            foreach(ModelAndHorsepowerOfCar item in  list)
            {
                Console.WriteLine ($"{item.Model}, {item.HorsePower}");
            }
        }
    }
}
