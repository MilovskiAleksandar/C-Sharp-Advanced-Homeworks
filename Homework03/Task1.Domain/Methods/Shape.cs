
namespace Task1.Domain.Methods
{
    public abstract class Shape
    {
        public int Id { get; set; }
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
