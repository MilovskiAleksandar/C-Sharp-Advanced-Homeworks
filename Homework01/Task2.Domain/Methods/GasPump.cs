
using Task2.Domain.Interfaces;

namespace Task2.Domain.Methods
{
    public class GasPump : IGasPump
    {
        public void PumpGas()
        {
            Console.WriteLine("You need to pump gas!");
        }
    }
}
