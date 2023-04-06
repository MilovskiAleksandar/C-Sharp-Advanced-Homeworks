
using Task1.Domain.Models;

namespace Task1.Domain
{
    public static class DataBase
    {
        public static List<Vehicle> Vehicles;

        static DataBase()
        {
            Vehicles = new List<Vehicle>()
            {
                new Vehicle(1, "Boat", 2013, 345),
                new Vehicle(2, "Truck", 2020, 100),
                new Car(3, "Car", 1990, 200, 100, new List<string>{"USA", "Greece"}),
                new Car(4, "Car", 2005, 145, 70, new List<string>{ "Australia", "Germany"}),
                new Bike(5, "Bike", 2022, 24, "White"),
                new Bike(6, "Bike", 2021, 25, "Red")
            };
        }
    }
}
