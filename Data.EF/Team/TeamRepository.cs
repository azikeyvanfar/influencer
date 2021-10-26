using Data.EF.Common;
using Domain.Contracts;
using Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Data.EF
{
    public class TeamRepository : BaseRepository<Team>, ITeamRepository
    {
        private readonly IConfiguration _config;
        private readonly InfluencerDbContext _ctx;

        public TeamRepository(IConfiguration config, InfluencerDbContext ctx) : base(ctx)
        {
            _config = config;
            _ctx = ctx;
        }

        //public async Task<List<Employee>> CustomersAsync()
        //{
        //    return await _ctx.employees.ToListAsync();
        //}
    }
}
