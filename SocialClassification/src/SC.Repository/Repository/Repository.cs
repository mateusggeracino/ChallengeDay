using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using SC.Domain.Models.Base;
using SC.Repository.Interfaces;

namespace SC.Repository.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly IConfiguration _config;
        protected IDbConnection Conn => new SqlConnection(_config.GetConnectionString("DefaultConnection"));

        protected Repository(IConfiguration config)
        {
            _config = config;
        }

        public T Add(T obj)
        {
            Conn.Insert(obj);
            return obj;
        }

        public T Update(T obj)
        {
            Conn.Update(obj);
            return obj;
        }

        public T GetById(int id)
        {
            return Conn.Get<T>(id);
        }

        public bool Delete(T obj)
        {
            Conn.Delete(obj);
            return true;
        }

        public IEnumerable<T> GetAll()
        {
            return Conn.GetAll<T>();
        }
    }
}