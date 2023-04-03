using Task2.Domain.Methods;

Console.WriteLine("CAR");
Car car = new Car("Audi", "RS7", 2500, 2022);
car.Drive();


Console.WriteLine("TRUCK");
Truck truck = new Truck("BMW", "E56", 16000, 99);
truck.Drive();

Console.WriteLine("CARCENTER");
CarCenter carCenter = new CarCenter("CarCompany", "Skopje", 56);
carCenter.WashCar(car);
carCenter.WashTrailer(truck);
carCenter.PumpGas();
carCenter.CheckVehicle();
carCenter.FixVehicle();

CarWash carWash = new CarWash();
carWash.WashCar(car);
carWash.WashTrailer(truck);

GasPump gasPump = new GasPump();
gasPump.PumpGas();

RepairService repairService = new RepairService();
repairService.CheckVehicle();
repairService.FixVehicle();
