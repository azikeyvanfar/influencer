using Dapper;
using Data.Dapper.Commons;
using Domain.Contracts;
using Domain.Entities.FSYS;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Data.Dapper
{
    public class SettingRepository : BaseRepository<Setting>, ISettingRepository
    {
        public SettingRepository(IConfiguration config) : base(config)
        {

        }

        //public List<SettingDto> GetSetting(string filter, int? pageNumber, int? pageSize)
        //{
        //    using (IDbConnection _cnn = Connection)
        //    {
        //        _cnn.Open();
        //        List<SettingDto> results = new List<SettingDto>();
        //        using (SqlMapper.GridReader result = _cnn.QueryMultiple("personcompanyget @Filter, @Pagenumber, @Pagesize", param: new { filter, pageNumber, pageSize }))
        //        {
        //            List<Setting> r = result.Read<Setting>().ToList();
        //            List<string> c = result.Read<string>().ToList();
        //            int count = result.Read<int>().Single();
        //            for (int i = 0; i < r.Count; i++)
        //            {
        //                SettingDto p = new SettingDto();
        //                p.Setting = r[i];
        //                p.CompanyName = c[i];
        //                p.TotalCount = count;
        //                results.Add(p);
        //            }
        //        }
        //        return results;
        //    }
        //}
        public List<Setting> Select(string code, Guid companyId)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                return _cnn.Query<Setting>("select * from FSYS.Setting where  Code = @code and CompanyId = @companyId", new { code, companyId }).ToList();
            }
        }
        public int ExecuteUpdate(string value, string code, Guid companyId)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                string sql = "Update FSYS.Setting Set Value = @value Where Code = @code And CompanyId = @companyId";
                return _cnn.Execute(sql, new { value, code, companyId });
            }
        }

    }
}
