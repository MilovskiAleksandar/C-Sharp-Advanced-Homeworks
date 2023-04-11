
using Task1.Domain.Methods;

namespace Task1.Domain.Database
{
    public class DataBase<T> where T : Shape
    {
        public List<T> values = new List<T>();

        public void Add(T value)
        {
            values.Add(value);
        }

        public void PrintArea()
        {
            foreach(T value in values)
            {
                Console.WriteLine($"Shape {value.Id} has area {value.GetArea()}");
            }
        }

        public void PrintPerimeter()
        {
            foreach (T value in values)
            {
                Console.WriteLine($"Shape {value.Id} has perimeter {value.GetPerimeter()}");
            }
        }
    }
}
