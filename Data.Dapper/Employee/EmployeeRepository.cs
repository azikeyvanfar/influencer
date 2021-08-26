using Data.Dapper.Commons;
using Domain.Contracts;
using Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Data.Dapper
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private readonly IConfiguration _config;

        public EmployeeRepository(IConfiguration config) : base(config)
        {
            _config = config;
        }

    }
}
