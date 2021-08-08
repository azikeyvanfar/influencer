using Dapper;
using Data.Dapper.Commons;
using Domain.Contracts.FSYS;
using Domain.Entities.FSYS;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Data.Dapper.FSYS
{
    public class PermissionRepository : BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepository(IConfiguration config) : base(config)
        {

        }
        public List<PermissionDto> GetPermission(string filter, int pageNumber, int pageSize)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                List<PermissionDto> results = new List<PermissionDto>();
                using (SqlMapper.GridReader result = _cnn.QueryMultiple("FSYS.PermissionGet @Filter, @Pagenumber, @Pagesize", param: new { filter, pageNumber, pageSize }))
                {
                    List<Permission> r = result.Read<Permission>().ToList();
                    List<string> c = result.Read<string>().ToList();
                    int count = result.Read<int>().Single();
                    int PerRow = pageSize * (pageNumber - 1);
                    int row;
                    for (int i = 0; i < r.Count; i++)
                    {
                        row = 1 + i + PerRow;
                        PermissionDto p = new PermissionDto();
                        //p.Row = row;
                        p.Permission = r[i];
                        p.LockName = c[i];
                        p.TotalCount = count;
                        results.Add(p);
                    }
                }
                return results;
            }
        }
        public List<Permission> GetAccessLevel(Guid UserId)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                string query = "execute FSYS.GetAccessLevel '" + UserId + "' ";
                return _cnn.Query<Permission>(query).ToList();
            }
        }

    }
}
