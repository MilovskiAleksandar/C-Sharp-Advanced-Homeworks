using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;
using TimeTracking.Domain.Interfaces;

namespace TimeTracking.Domain.Models
{
    public class Exercising : Track, IExercising
    {
        public void AddType()
        {
            Exercisings.Add(ExercisingTypes.General);
            Exercisings.Add(ExercisingTypes.Running);
            Exercisings.Add(ExercisingTypes.Sport);
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Tittle: {Title} \n Descriptions: {Description}");
        }

        public void PrintType()
        {
            foreach(ExercisingTypes type in Exercisings)
            {
                Console.WriteLine(type);
            }
        }
    }
}
