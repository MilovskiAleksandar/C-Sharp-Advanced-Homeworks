
using Task2.Domain.Interfaces;

namespace Task2.Domain.Methods
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("Your vehicle was checked and is alright!");
        }

        public bool FixVehicle()
        {
            Console.WriteLine("Your vehicle is fixed!");
            return true;
        }
    }
}
