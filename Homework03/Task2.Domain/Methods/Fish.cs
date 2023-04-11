
namespace Task2.Domain.Methods
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Fish with Name: {Name}, Type: {Type}, Age: {Age}, Color: {Color}, Size: {Size} meters");
        }
    }
}
