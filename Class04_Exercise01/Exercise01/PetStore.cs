using Exercise01.Models;

namespace Exercise01
{
    public class PetStore<T> where T : Pet
    {
        public List<T> listOfPets = new List<T>();

        public void PrintPets ()

        {
            Console.WriteLine($"\n--- Printing pets of type {typeof(T).Name} ---");
            foreach (var pet in listOfPets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            T foundPet = listOfPets.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
            if (foundPet != null)
            {
                listOfPets.Remove(foundPet);
                Console.WriteLine($"You bought {foundPet.Name} the {foundPet.Type}! Enjoy your new pet!");
            }
            else
            {
                Console.WriteLine($"Sorry, no pet named {name} was found.");
            }

        }
        }

}
