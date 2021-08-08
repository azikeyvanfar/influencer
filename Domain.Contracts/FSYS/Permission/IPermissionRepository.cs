using Domain.Contracts.Commons;
using Domain.Entities.FSYS;
using System;
using System.Collections.Generic;

namespace Domain.Contracts.FSYS
{
    public interface IPermissionRepository : IBaseRepository<Permission>
    {
        List<PermissionDto> GetPermission(string filter, int pageNumber, int pageSize);
        List<Permission> GetAccessLevel(Guid UserId);
    }
}
