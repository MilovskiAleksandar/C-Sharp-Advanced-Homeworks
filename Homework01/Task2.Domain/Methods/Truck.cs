
using Task2.Domain.Interfaces;

namespace Task2.Domain.Methods
{
    public class Truck : Vehicle
    {
        public int MetersLong { get; set; }
        public Truck() { }

        public Truck(string name, string model, long kilometersDrived, int metersLong) : base(name, model, kilometersDrived)
        {
            if(metersLong > 0)
            {
                MetersLong = metersLong;
            }
            else
            {
                Console.WriteLine("Invalid input for meters");
            }
        }
        public override void Drive()
        {
            Console.WriteLine($"{Name}, model {Model} is driving...");
        }
    }
}
