
namespace Task1.Domain.Methods
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public override double GetArea()
        {
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}
