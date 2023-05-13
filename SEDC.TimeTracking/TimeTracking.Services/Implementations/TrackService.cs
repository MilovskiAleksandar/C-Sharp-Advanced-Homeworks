using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.DataBase;
using TimeTracking.Domain.DBInterface;
using TimeTracking.Domain.Models;
using TimeTracking.Services.Interfaces;

namespace TimeTracking.Services.Implementations
{
    public class TrackService<T> : ITrackService<T> where T : Track
    {
        private IDatabase<T> _database;

        public TrackService()
        {
            _database = new FileDataBase<T>();
        }
        public void AddTrack(T track)
        {
            _database.Add(track);
        }
    }
}
