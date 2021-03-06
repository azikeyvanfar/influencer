using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Entities.Context;

namespace Data.EF.Common
{
    public class InfluencerDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<UserArticle> userArticles { get; set; }
        public DbSet<SiteSetting> siteSettings { get; set; }
        public DbSet<Advertise> advertises { get; set; }
        public DbSet<AdvertiseDo> advertisesDo { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<Languages> languages{ get; set; }


        public InfluencerDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // call the base if you are using Identity service.
            // Important
            base.OnModelCreating(builder);

            // Code here ...
        }
    }
}
