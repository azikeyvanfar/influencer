using Domain.Contracts.Commons;
using Domain.Entities.Commons;
using Domain.Entities.FORG;
using System.Collections.Generic;

namespace Domain.Contracts.FORG
{
    public interface IUserRepository : IBaseRepository<User>
    {
        List<User> GetUser(string filter, int pageNumber, int pageSize);
        User FindUser(string userName, string password,string companyCode);
        List<Base> GetUsers();
    }
}
