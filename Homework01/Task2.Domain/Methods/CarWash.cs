
using Task2.Domain.Interfaces;

namespace Task2.Domain.Methods
{
    public class CarWash : ICarWash
    {
        public bool WashCar(Car car)
        {
            Console.WriteLine("Your car needs a wash!");
            return true;
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"Your truck needs a wash");
        }
    }
}
