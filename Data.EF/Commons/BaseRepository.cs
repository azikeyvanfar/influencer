using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Data.EF.Commons
{
    public class BaseRepository<T> where T : class
    {
        private readonly IConfiguration _config;

        public BaseRepository(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        public void Remove(T model)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                _cnn.Delete(model);
            }
        }
        public bool Update(T model)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                return _cnn.Update(model);
            }
        }
        public long Add(T model)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                return _cnn.Insert(model);
            }
        }
        public T Fetch(Guid id)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                return _cnn.Get<T>(id);
            }
        }
        public List<T> GetAll()
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                return _cnn.GetAll<T>().ToList();
            }
        }
    }
}
