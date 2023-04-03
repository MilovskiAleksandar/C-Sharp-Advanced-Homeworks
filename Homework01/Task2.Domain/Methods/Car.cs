
using Task2.Domain.Interfaces;

namespace Task2.Domain.Methods
{
    public class Car : Vehicle
    {
        public int YearProduction { get; set; }
        public Car() { }
        public Car(string name, string model, long kilometersDrived, int yearProduction) : base(name, model, kilometersDrived)
        {
            YearProduction = yearProduction;
        }
        public override void Drive()
        {
            Console.WriteLine($"The car with name {Name} is driving");
        }

       
    }
}
