
using Task1.Domain.Interfaces;

namespace Task1.Domain.Methods
{
    public class Cat : Animal, ICat
    {
        public int Id { get; set; } 

        public Cat() { }

        public Cat(string name, string color, int age, int id) : base(name, color, age)
        {
            if(id > 0)
            {
                Id = id;
            }
            else
            {
                Console.WriteLine("Invalid input for ID");
            }
            
        }
        public string Eat(string food)
        {
            Console.WriteLine($"The cat with name {Name} is eating {food}");
            return food;
           
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"Animal name is: {Name}, has color {Color}, and age {Age}");
        }
    }
}
