using Domain.Contracts.Commons;
using Domain.Entities.FSYS;
using System;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface ISettingRepository : IBaseRepository<Setting>
    {
        List<Setting> Select(string code, Guid companyId);
        int ExecuteUpdate(string value, string code, Guid companyId);
    }
}