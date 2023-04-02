
using Task2.Domain.Interfaces;

namespace Task2.Domain.Methods
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {

        public string CompanyName { get; set; }
        public string Location { get; set; }
        public int CarsInStock { get; set; }
        public CarCenter() { }
        public CarCenter(string companyName, string location, int carsInStock)
        {
            if(string.IsNullOrEmpty(companyName))
            {
                Console.WriteLine("Invalid input for company name");
            }
            CompanyName = companyName;
            if(string.IsNullOrEmpty(location))
            {
                Console.WriteLine("Invalid input for location");
            }
            Location = location;
            if(carsInStock > 0)
            {
                CarsInStock = carsInStock;
                Console.WriteLine($"We have {CarsInStock} cars and trucks in our company!");
            }
            else
            {
                Console.WriteLine("Invalid input for cars in stock");
            }
            
        }

        public void CheckVehicle()
        {
            Console.WriteLine("We checked your car and is totally alright!");
        }

        public bool FixVehicle()
        {
            Console.WriteLine("Your can needs to be fixed!");
            return false;
        }

        public void PumpGas()
        {
            Console.WriteLine("If your car has 250km driven you need to refuel your gas!");
        }

        public bool WashCar(Car car)
        {
            Console.WriteLine("You dont need to wash your car because its NEW!");
            return true;
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine("You dont need to wash your truck because its NEW!");
        }
    }
}
