// EXERCISE 01
//➢ Create 4 classes:
//➢ Pet( abstract ) with Name, Type, Age and abstract PrintInfo()
//➢ Dog(from Pet ) with GoodBoy and FavoriteFood
//➢ Cat( from Pet ) with Lazy and LivesLeft
//➢ Fish( from Pet ) with color, size
//➢ Create a PetStore generic class with :
//➢ Generic list of pets - Dogs, Cats or Fish depending on what is passed as T
//➢ Generic method printsPets() - Prints Dogs, Cats or Fish depending on what is
//passed as T
//➢ BuyPet() - Method that takes ‘name’ as parameter, find the first pet by that name,
//removes it from the list and gives a success message.If there is no pet by that
//name, inform the customer
//➢ Create a Dog, Cat and fish store with 2 pets each
//➢ Buy a dog and a cat from the Dog and Cat store
//➢ Call PrintPets() method on all stores


using Exercise01.Models;
using Exercise01;

public class Program
{
    public static void Main()
    {
        
        PetStore<Dog> dogStore = new PetStore<Dog>();
        PetStore<Cat> catStore = new PetStore<Cat>();
        PetStore<Fish> fishStore = new PetStore<Fish>();

       
        dogStore.listOfPets.Add(new Dog("Dzeki", 5, true, "Koski"));
        dogStore.listOfPets.Add(new Dog("Sky", 4, false, "Chicken"));

        catStore.listOfPets.Add(new Cat("Bela", 2, true, 7));
        catStore.listOfPets.Add(new Cat("Luna", 4, false, 9));

        fishStore.listOfPets.Add(new Fish("Nemo", 1, "Orange", "Small"));
        fishStore.listOfPets.Add(new Fish("Zlatka", 2, "Blue", "Medium"));

        dogStore.BuyPet("Dzeki");
        catStore.BuyPet("Luna");

        dogStore.PrintPets();
        catStore.PrintPets();
        fishStore.PrintPets();

        Console.ReadLine();
    }
}