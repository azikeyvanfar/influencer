using Data.EF;
using Data.EF.Common;
using Domain.Contracts;
using Domain.Entities;
using Domain.Entities.Context;
using influencer.Models;
using influencer.Repositories;
using influencer.Security.Default;
using influencer.Security.DynamicRole;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Globalization;

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

            services.AddDbContextPool<InfluencerDbContext>(options =>
                {
                    options.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
                });

            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    options.ClientId = "597636127689-g50c5hi3q3h8h5dibukijkhv410gbnhp.apps.googleusercontent.com";
                    options.ClientSecret = "W_xZMX7Mz1hwHcgL-J8eST7A";
                });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix,
                    options => { options.ResourcesPath = "Resources"; })
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                        factory.Create(typeof(ShareResource));
                });
            services.AddLocalization(options=>options.ResourcesPath= "Resources");
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
                {
                    options.Password.RequiredUniqueChars = 0;

                    options.User.RequireUniqueEmail = true;
                    options.User.AllowedUserNameCharacters =
                        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-";

                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
                })
                .AddEntityFrameworkStores<InfluencerDbContext>()
                .AddDefaultTokenProviders();

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
            services.AddTransient<IUtilitiesRepository, UtilitiesRepository>();
            services.AddTransient<IMessageSender, MessageSender>();
            services.AddScoped<IAuthorizationHandler, DynamicRoleHandler>();
            services.AddSingleton<IAuthorizationHandler, ClaimHandler>();
            services.AddScoped<ISiteSettingRepository, SiteSettingRepository>();
            services.AddScoped<IUserArticleRepository, UserArticleRepository>();
            services.AddScoped<IAdvertiseRepository, AdvertiseRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>(); 
            services.AddScoped<ILanguagesRepository, LanguagesRepository>(); 

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment() || env.IsStaging())
            //{
                app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            var supportedCultures = new List<CultureInfo>()
            {
                new CultureInfo("en-US"),
                new CultureInfo("fa-IR"),
                new CultureInfo("tr-TR")
            };
            var options = new RequestLocalizationOptions()
            {
                DefaultRequestCulture = new RequestCulture("en-US"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures,
                RequestCultureProviders = new List<IRequestCultureProvider>()
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                }
            };
            app.UseRequestLocalization(options);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Languages}/{id?}");
            });
        }


        private bool ClaimOrRole(AuthorizationHandlerContext context)
            => context.User.HasClaim(ClaimTypesStore.EmployeeList, true.ToString()) ||
               context.User.IsInRole("Admin");

    }
}
