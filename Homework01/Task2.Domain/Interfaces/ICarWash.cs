
using Task2.Domain.Methods;

namespace Task2.Domain.Interfaces
{
    public interface ICarWash
    {
        bool WashCar(Car car);
        void WashTrailer(Truck truck);
    }
}
