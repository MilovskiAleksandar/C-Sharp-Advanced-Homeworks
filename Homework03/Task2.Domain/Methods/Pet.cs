
namespace Task2.Domain.Methods
{
    public abstract class Pet
    {
        public  string Name { get; set; }
        public  string Type { get; set; }
        public  int Age { get; set; }
        public abstract void PrintInfo();
    }
}
