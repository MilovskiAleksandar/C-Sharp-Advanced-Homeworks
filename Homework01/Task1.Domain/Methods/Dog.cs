
using Task1.Domain.Interfaces;

namespace Task1.Domain.Methods
{
    public class Dog : Animal, IDog
    {
        public int Kilos { get; set; }

        public Dog() { }

        public Dog(string name, string color, int age, int kilos) : base(name, color, age)
        {
            if(kilos > 0 )
            {
                Kilos = kilos;
                
            }
            else
            {
                Console.WriteLine("Invalid input for kilos");
            }
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"Animal name is: {Name}, has color {Color}, and age {Age}, and weights {Kilos} kg");
        }
        public void Bark()
        {
            if(Name.Length > 3)
            {
                Console.WriteLine($"{Name} can bark");
            }
            else
            {
                Console.WriteLine($"{Name} can`t bark");
            }
        }


    }
}
