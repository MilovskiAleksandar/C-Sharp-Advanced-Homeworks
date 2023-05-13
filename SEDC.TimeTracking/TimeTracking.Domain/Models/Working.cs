using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;
using TimeTracking.Domain.Interfaces;

namespace TimeTracking.Domain.Models
{
    public class Working : Track, IWorking
    {
        public void AddType()
        {
            Workings.Add(Enums.WorkingTypes.Office);
            Workings.Add(Enums.WorkingTypes.Home);
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Tittle: {Title} \n Descriptions: {Description} \n");
        }

        public void PrintType()
        {
            foreach(WorkingTypes workingTypes in Workings)
            {
                Console.WriteLine(workingTypes);
            }
        }
    }
}
