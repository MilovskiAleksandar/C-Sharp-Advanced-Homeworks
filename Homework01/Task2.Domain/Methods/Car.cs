
using Task2.Domain.Interfaces;

namespace Task2.Domain.Methods
{
    public class Car : Vehicle, ICarWash, IGasPump, IRepairService
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

        public bool WashCar(Car car)
        {
            if(KilometersDrived > 100)
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
            if(KilometersDrived > 200)
            {
                Console.WriteLine($"Your car need to pump gas!");
            }
            else
            {
                Console.WriteLine("You are safe with the gas for long period");
            }
        }

        public void CheckVehicle()
        {
            Console.WriteLine("You need to check your vehicle after every 5000km!");
        }

        public bool FixVehicle()
        {
            if(KilometersDrived > 5000)
            {
                Console.WriteLine("You need to fix your car");
                return true;
            }
            else
            {
                Console.WriteLine("You dont need to fix your car");
                return false;
            }
        }

        //public void WashTrailer(Truck truck)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
