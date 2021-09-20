using Data.EF.Common;
using Domain.Contracts;
using Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Data.EF
{
    public class AdvertiseRepository : BaseRepository<Advertise>, IAdvertiseRepository
    {
        private readonly IConfiguration _config;
        private readonly InfluencerDbContext _ctx;

        public AdvertiseRepository(IConfiguration config, InfluencerDbContext ctx) : base(ctx)
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
