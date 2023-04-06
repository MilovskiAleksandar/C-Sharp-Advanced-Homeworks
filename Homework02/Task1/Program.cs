
using Task1;
using Task1.Domain;
using Task1.Domain.Helpers;
using Task1.Domain.Models;

foreach(Vehicle vehicle in DataBase.Vehicles)
{
    vehicle.PrintVehicle();

}

Bike bike = new Bike(10, "Bike", 1900, 10, "Brown");
Car car = new Car(22, "Car", 1991, 23456, 20, new List<string> { "Macedonia", "Serbia", "France"});

Validator.Validate(bike);
bike.PrintVehicle();
Validator.Validate(car);
car.PrintVehicle();

Validator.Validate(DataBase.Vehicles[0]);