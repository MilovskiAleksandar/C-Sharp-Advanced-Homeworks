using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Models;

namespace TimeTracking.Services.Interfaces
{
    public interface ITrackService<T> where T : Track
    {
        void AddTrack(T track);
        
        
    }
}
