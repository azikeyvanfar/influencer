﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace influencer.Models.Context
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<SiteSetting> SiteSettings { get; set; }


        public AppDbContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
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
