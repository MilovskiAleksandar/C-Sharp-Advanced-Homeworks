
namespace Task1.Domain.Models
{
    public class Vehicle
    {
        public int Id { get; set; } 
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public Vehicle() { }

        public Vehicle(int id, string type, int yearOfProduction, int batchNumber)
        {
            Id = id;          
            Type = type;           
            YearOfProduction = yearOfProduction;            
            BatchNumber = batchNumber;
        }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"ID: {Id} \n Type: {Type} \n Year of production: {YearOfProduction}");
        }
    }
}
