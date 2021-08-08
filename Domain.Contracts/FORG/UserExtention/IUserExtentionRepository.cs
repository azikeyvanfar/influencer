using Domain.Contracts.Commons;
using Domain.Entities.FORG;
using System;
using System.Collections.Generic;

namespace Domain.Contracts.FORG
{
    public interface IUserExtentionRepository : IBaseRepository<UserExtention>
    {
        UserExtention FindUserExtention(Guid UserId);
        List<UserExtention> GetUserExtentionToken(Guid token);
    }
}
