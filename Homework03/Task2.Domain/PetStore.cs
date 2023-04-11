
using Task2.Domain.Methods;

namespace Task2.Domain
{
    public class PetStore<T> where T : Pet
    {
        public List<T> pets = new List<T>();

        public void Add(T value)
        {
            pets.Add(value);
        }
        public void PrintsPets()
        {
            foreach (T pet in pets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name)
        {
            var pet = pets.FirstOrDefault(p => p.Name == name);
            if (pet != null)
            {
                pets.Remove(pet);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You have successfully bought {name}.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sorry, there is no pet with the name {name}.");
                Console.ResetColor();
            }
        }
    }
}
