using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Enums;

namespace TimeTracking.Domain.Models
{
    public abstract class Track : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Time { get; set; }

        public List<ReadingTypes> Readings { get; set; }
        public List<ExercisingTypes> Exercisings { get; set; }
        public List<WorkingTypes> Workings { get; set; }
        public List<HobbiesTypes> Hobbies { get; set; }




        public Track()
        {
            Readings = new List<ReadingTypes>();
            Exercisings = new List<ExercisingTypes>();
            Workings = new List<WorkingTypes>();
        }
    }
}
