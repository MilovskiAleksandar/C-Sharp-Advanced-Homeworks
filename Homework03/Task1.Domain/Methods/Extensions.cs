
namespace Task1.Domain.Methods
{
    public static class Extensions
    {
        public static void PrintCircleInfo(this Circle circle)
        {
            Console.WriteLine($"Circle with id: {circle.Id} has radius {circle.Radius}, area {circle.GetArea()}, and perimeter {circle.GetPerimeter()}");
        }

        public static void PrintRectangleInfo(this Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle with id: {rectangle.Id} has sides {rectangle.SideA} and {rectangle.SideB}, area {rectangle.GetArea()}, and perimeter {rectangle.GetPerimeter()}");
        }
    }
}
