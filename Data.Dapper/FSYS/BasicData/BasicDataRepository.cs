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
    public class BasicDataRepository : BaseRepository<BasicData>, IBasicDataRepository
    {
        public BasicDataRepository(IConfiguration config) : base(config)
        {

        }
        public List<BasicDataList> GetBasicData(string filter, int pageNumber, int pageSize, string groupKey, Guid compayId)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                List<BasicDataList> results = _cnn.Query<BasicDataList>("FSYS.BasicDataGet @Filter, @Pagenumber, @Pagesize ,@GroupKey,@compayId", param: new { filter, pageNumber, pageSize, groupKey, compayId }).ToList();
                return results;
            }
        }
        public int InsetToBasicData(BasicData basicData)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                using (var transaction = _cnn.BeginTransaction())
                {
                    var affectedRows = _cnn.Execute("FSYS.BasicDataGetMaxValueAndViewOrder @BasicDataId, @Text, @GroupKey, @Editable, @CompanyId, @Code", new { basicData.BasicDataId, basicData.Text, basicData.GroupKey, basicData.Editable, basicData.CompanyId, basicData.Code }, transaction: transaction);
                    transaction.Commit();
                    return affectedRows;
                }

            }

        }

        public List<BasicData> GetBasicDataByGroupKey(string groupKey)
        {
            string sql = "Select * from FSYS.BasicData ";
            if (groupKey != "")
                sql += "  where GroupKey = '" + groupKey + "'";

            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                return _cnn.Query<BasicData>(sql).ToList();
            }
        }

        public int UpViewOrder(Guid CurrentId, int CurrentOrderView, Guid OldId, int OldOrderView)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();

                using (var transaction = _cnn.BeginTransaction())
                {
                    var affectedRows = _cnn.Execute("FSYS.BasicDataUpViewOrder @CurrentId,@CurrentOrderView,@OldId,@OldOrderView", new { CurrentId, CurrentOrderView, OldId, OldOrderView }, transaction: transaction);
                    transaction.Commit();
                    return affectedRows;
                }
            }

        }

        public int DownViewOrder(Guid CurrentId, int CurrentOrderView, Guid NextId, int NextOrderView)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();

                using (var transaction = _cnn.BeginTransaction())
                {
                    var affectedRows = _cnn.Execute("FSYS.BasicDataDownViewOrder @CurrentId,@CurrentOrderView,@NextId,@NextOrderView", new { CurrentId, CurrentOrderView, NextId, NextOrderView }, transaction: transaction);
                    transaction.Commit();
                    return affectedRows;
                }
            }
        }

        //public List<BasicData> GetMoveTimes_Rpt(Guid ModuleId)
        //{
        //    using (IDbConnection _cnn = Connection)
        //    {
        //        _cnn.Open();
        //        return _cnn.Query("FFMS.uspFmsGetEndCreditDatetimeModule  @ModuleId", param: new { ModuleId }).ToList();

        //    }
        //}

    }
}