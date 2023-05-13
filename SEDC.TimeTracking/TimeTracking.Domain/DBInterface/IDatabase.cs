using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Models;

namespace TimeTracking.Domain.DBInterface
{
    public interface IDatabase<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Add(T entity);
        void RemoveById(int id);
        void Update(T entity);
    }
}
