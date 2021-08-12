using System;
using EndPoint.WebUI.Areas.Identity.Data;
using EndPoint.WebUI.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EndPoint.WebUI.Areas.Identity.IdentityHostingStartup))]
namespace EndPoint.WebUI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EndPointWebUIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EndPointWebUIContextConnection")));

                services.AddDefaultIdentity<EndPointWebUIUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<EndPointWebUIContext>();
            });
        }
    }
}