
namespace Task2.Domain.Methods
{
    public class Dog : Pet
    {
        public string FavoriteFood { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Dog with name {Name}, Type: {Type}, has age: {Age}, and his favorite food is {FavoriteFood}");
        }
    }
}
