using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.DBInterface;
using TimeTracking.Domain.Models;

namespace TimeTracking.Domain.DataBase
{
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        private List<T> _values {  get; set; }
        private int _id;

        public Database()
        {
            _values = new List<T>();
            _id = 1;
        }

        public int Add(T entity)
        {
           entity.Id = _id++;
            _values.Add(entity);
            return entity.Id;
        }

        public List<T> GetAll()
        {
           return _values;
        }

        public T GetById(int id)
        {
           T value = _values.FirstOrDefault(x => x.Id == id);
            if(value == null)
            {
                throw new Exception($"Item with id {id} was not found");
            }
            return value;
        }

        public void RemoveById(int id)
        {
            T value = _values.FirstOrDefault(x => x.Id == id);
            if (value == null)
            {
                throw new Exception($"Item with id {id} was not found");
            }
            _values.Remove(value);
        }

        public void Update(T entity)
        {
            T value = _values.FirstOrDefault(x => x.Id == entity.Id);
            if (value == null)
            {
                throw new Exception($"Item with id {entity.Id} was not found");
            }

            value = entity;
        }
    }
}
