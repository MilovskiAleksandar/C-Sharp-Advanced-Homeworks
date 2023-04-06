
using Task1.Domain.Models;

namespace Task1.Domain.Helpers
{
    public static class Validator
    {
        public static void Validate(Vehicle vehicle)
        {
            if(vehicle.Id < 0)
            {
                Console.WriteLine("Invalid input for ID");
            }

            if (string.IsNullOrEmpty(vehicle.Type))
            {
                Console.WriteLine("Invalid input for Type");
            }

            if(vehicle.YearOfProduction < 0)
            {
                Console.WriteLine("Invalid input for Year of production");
            }
        }
    }
}
