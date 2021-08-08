using Domain.Contracts.Commons;
using Domain.Entities.FSYS;
using System;
using System.Collections.Generic;
namespace Domain.Contracts
{
    public interface IBasicDataRepository : IBaseRepository<BasicData>
    {
        List<BasicDataList> GetBasicData(string filter, int pageNumber, int pageSize, string groupKey, Guid compayId);
        int InsetToBasicData(BasicData BaseData);
        List<BasicData> GetBasicDataByGroupKey(string groupKey);
        int UpViewOrder(Guid CurrentId, int CurrentOrderView, Guid OldId, int OldOrderView);
        int DownViewOrder(Guid CurrentId, int CurrentOrderView, Guid NextId, int NextOrderView);

    }
}