
using Task2.Domain.Interfaces;

namespace Task2.Domain.Methods
{
    public class Truck : Vehicle, ICarWash, IGasPump, IRepairService
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

        public bool WashCar(Car car)
        {
            if (KilometersDrived > 100)
            {
                Console.WriteLine("You need to wash your car");
                return true;
            }
            else
            {
                Console.WriteLine("You don`t need to wash your car");
                return false;
            }
        }

        public void WashTrailer(Truck truck)
        {
            if (KilometersDrived > 100)
            {
                Console.WriteLine("You need to wash your truck");
            }
            else
            {
                Console.WriteLine("You don`t need to wash your truck");
            }
        }

        public void PumpGas()
        {
            if (KilometersDrived > 200)
            {
                Console.WriteLine($"Your truck need to pump gas!");
            }
            else
            {
                Console.WriteLine("You are safe with the gas for long period");
            }
        }

        public void CheckVehicle()
        {
            Console.WriteLine("You need to check your truck after every 5000km!");
        }

        public bool FixVehicle()
        {
            if (KilometersDrived > 15000)
            {
                Console.WriteLine("You need to fix your truck");
                return true;
            }
            else
            {
                Console.WriteLine("You dont need to fix your truck");
                return false;
            }
        }

    }
}
