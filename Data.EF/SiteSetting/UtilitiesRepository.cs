using Data.EF.Common;
using Domain.Contracts;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace influencer.Repositories
{
    public class UtilitiesRepository : BaseRepository<SiteSetting>, IUtilitiesRepository
    {
        private readonly IConfiguration _config;
        private readonly InfluencerDbContext _ctx;

        public UtilitiesRepository(IConfiguration config, InfluencerDbContext ctx) : base(ctx)
        {
            _config = config;
            _ctx = ctx;
        }

        public IList<ActionAndControllerName> AreaAndActionAndControllerNamesList()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            var contradistinction = asm.GetTypes()
                .Where(type => typeof(Controller).IsAssignableFrom(type))
                .SelectMany(type =>
                    type.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
                .Select(x => new
                {
                    Controller = x.DeclaringType?.Name,
                    Action = x.Name,
                    Area = x.DeclaringType?.CustomAttributes.Where(c => c.AttributeType == typeof(AreaAttribute))
                });

            var list = new List<ActionAndControllerName>();

            foreach (var item in contradistinction)
            {
                if (item.Area.Count() != 0)
                {
                    list.Add(new ActionAndControllerName()
                    {
                        ControllerName = item.Controller,
                        ActionName = item.Action,
                        AreaName = item.Area.Select(v => v.ConstructorArguments[0].Value.ToString()).FirstOrDefault()
                    });
                }
                else
                {
                    list.Add(new ActionAndControllerName()
                    {
                        ControllerName = item.Controller,
                        ActionName = item.Action,
                        AreaName = null,
                    });
                }
            }

            return list.Distinct().ToList();
        }

        public IList<string> GetAllAreasNames()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            var contradistinction = asm.GetTypes()
                .Where(type => typeof(Controller).IsAssignableFrom(type))
                .SelectMany(type =>
                    type.GetMethods(BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Public))
                .Select(x => new
                {
                    Area = x.DeclaringType?.CustomAttributes.Where(c => c.AttributeType == typeof(AreaAttribute))

                });

            var list = new List<string>();

            foreach (var item in contradistinction)
            {
                list.Add(item.Area.Select(v => v.ConstructorArguments[0].Value.ToString()).FirstOrDefault());
            }

            if (list.All(string.IsNullOrEmpty))
            {
                return new List<string>();
            }

            list.RemoveAll(x => x == null);

            return list.Distinct().ToList();
        }

        public string DataBaseRoleValidationGuid()
        {
            var roleValidationGuid =
                _ctx.siteSettings.SingleOrDefault(s => s.Key == "RoleValidationGuid")?.Value;

            while (roleValidationGuid == null)
            {
                _ctx.Add(new SiteSetting()
                {
                    Key = "RoleValidationGuid",
                    Value = Guid.NewGuid().ToString(),
                    LastTimeChanged = DateTime.Now
                });

                _ctx.SaveChanges();

                roleValidationGuid =
                    _ctx.siteSettings.SingleOrDefault(s => s.Key == "RoleValidationGuid")?.Value;
            }

            return roleValidationGuid;
        }

    }
}
