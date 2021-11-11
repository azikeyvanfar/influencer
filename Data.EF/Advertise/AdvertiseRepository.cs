using Data.EF.Common;
using Domain.Contracts;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public IEnumerable<AdvertiseDo> SelectAllWithInsta()
        {
            return _ctx.advertisesDo.FromSqlRaw("select A.*,U.InstagramPage from dbo.Advertises A left outer join dbo.AspNetUsers U on U.Id = A.UserId Order By OrderAdvertise").ToList();
        }
    }
}
