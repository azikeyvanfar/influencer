using System;
using Data.EF;
using Domain.Contracts;
using influencer.Models;
using influencer.Models.Context;
using influencer.Repositories;
using influencer.Security.Default;
using influencer.Security.DynamicRole;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersianTranslation.Identity;

namespace influencer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            services.AddDbContextPool<AppDbContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
                });

            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    options.ClientId = "597636127689-g50c5hi3q3h8h5dibukijkhv410gbnhp.apps.googleusercontent.com";
                    options.ClientSecret = "W_xZMX7Mz1hwHcgL-J8eST7A";
                });

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                {
                    options.Password.RequiredUniqueChars = 0;

                    options.User.RequireUniqueEmail = true;
                    options.User.AllowedUserNameCharacters =
                        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-";

                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
                })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders()
                .AddErrorDescriber<PersianIdentityErrorDescriber>();

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/Account/AccessDenied";
                //options.Cookie.Name = "IdentityProj";
                options.LoginPath = "/Account/Login";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
            });

            services.Configure<SecurityStampValidatorOptions>(option =>
            {
                // option.ValidationInterval = TimeSpan.FromSeconds(15);
            });

            services.AddAuthorization(option =>
            {
                option.AddPolicy("EmployeeListPolicy", policy => policy
                        .RequireClaim(ClaimTypesStore.EmployeeList, false.ToString(), true.ToString()));

                option.AddPolicy("ClaimOrRole", policy =>
                     policy.RequireAssertion(ClaimOrRole));

                option.AddPolicy("ClaimRequirement", policy =>
                     policy.Requirements.Add(new ClaimRequirement(ClaimTypesStore.EmployeeList, true.ToString())));

                option.AddPolicy("DynamicRole", policy =>
                    policy.Requirements.Add(new DynamicRoleRequirement()));
            });

            services.AddMemoryCache();
            services.AddHttpContextAccessor();
            services.AddTransient<IUtilities, Utilities>();
            services.AddScoped<IMessageSender, MessageSender>();
            services.AddScoped<IAuthorizationHandler, DynamicRoleHandler>();
            services.AddSingleton<IAuthorizationHandler, ClaimHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }


        private bool ClaimOrRole(AuthorizationHandlerContext context)
            => context.User.HasClaim(ClaimTypesStore.EmployeeList, true.ToString()) ||
               context.User.IsInRole("Admin");

    }
}
