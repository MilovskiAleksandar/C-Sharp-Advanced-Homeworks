
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Task2.Domain.Methods
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public long KilometersDrived { get; set; }

        public Vehicle() { }
        public Vehicle(string name, string model, long kilometersDrived)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input for name");
            }

            Name = name;

            if (string.IsNullOrEmpty(model))
            {
                Console.WriteLine("Invalid input for color");
            }
            Model = model;

            if (kilometersDrived > 0)
            {
                KilometersDrived = kilometersDrived;
            }
            else
            {
                Console.WriteLine("Invalid input for age");
            }
        }

        public abstract void Drive();
    }
}
