
using Task1.Domain.Interfaces;

namespace Task1.Domain.Methods
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Animal() { }

        public Animal(string name, string color, int age)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input for name");
            }
            Name = name;
            if(string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input for color");
            }
            Color = color;
            if(age > 0)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Invalid input for age");
            }
           
        }

        public abstract void PrintAnimal();
    }
}
