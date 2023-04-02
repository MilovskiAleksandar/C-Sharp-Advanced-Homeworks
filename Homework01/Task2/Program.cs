using Task2.Domain.Methods;

Console.WriteLine("CAR");
Car car = new Car("Audi", "RS7", 2500, 2022);
car.Drive();
car.WashCar(car);
car.PumpGas();
car.CheckVehicle();
car.FixVehicle();

Console.WriteLine("TRUCK");
Truck truck = new Truck("BMW", "E56", 16000, 99);
truck.Drive();
truck.WashTrailer(truck);
truck.PumpGas();
truck.CheckVehicle();
truck.FixVehicle();

Console.WriteLine("CARCENTER");
CarCenter carCenter = new CarCenter("CarCompany", "Skopje", 56);
carCenter.WashCar(car);
carCenter.WashTrailer(truck);
carCenter.PumpGas();
carCenter.CheckVehicle();
carCenter.FixVehicle();
