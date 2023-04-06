
namespace Task1.Domain.Models
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }
        public Bike() { }
        public Bike(int id, string type, int yearOfProduction, int batchNumber, string color) : base(id, type, yearOfProduction, batchNumber)
        {
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input for color");
            }
            Color = color;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"Year of production for this bike is: {YearOfProduction} \n Color: {Color}");
        }
    }
}
