using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;
using TimeTracking.Domain.Interfaces;

namespace TimeTracking.Domain.Models
{
    public class Hobbies : Track, IHobbies
    {
        public void AddType()
        {
            Hobbies.Add(Enums.HobbiesTypes.Football);
            Hobbies.Add(Enums.HobbiesTypes.Basketball);
            Hobbies.Add(Enums.HobbiesTypes.Golf);
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Tittle: {Title} \n Descriptions: {Description} \n");
        }

        public void PrintType()
        {
            foreach(HobbiesTypes hobbiesTypes in Hobbies)
            {
                Console.WriteLine(hobbiesTypes);
            }
        }
    }
}
