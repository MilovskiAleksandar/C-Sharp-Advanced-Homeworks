using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;
using TimeTracking.Domain.Interfaces;

namespace TimeTracking.Domain.Models
{
    public class Readings : Track, IReading
    {
        public int Page { get; set; }
        public void AddType()
        {
            Readings.Add(Enums.ReadingTypes.ProfessionalLiterature);
            Readings.Add(Enums.ReadingTypes.BellesLettres);
            Readings.Add(Enums.ReadingTypes.Fiction);
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Tittle: {Title} \n Descriptions: {Description} \n");
        }

        public void PrintType()
        {
            foreach(ReadingTypes readingTypes in Readings)
            {
                Console.WriteLine(readingTypes);
            }
        }
    }
}
