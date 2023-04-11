
namespace Task2.Domain.Methods
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"Cat with Name: {Name}, Type: {Type}, Age: {Age}, Lazy: {IsLazy}, Lives left: {LivesLeft}");
        }
    }
}
