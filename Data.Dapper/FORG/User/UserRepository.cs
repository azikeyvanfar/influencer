using Dapper;
using Data.Dapper.Commons;
using Domain.Contracts.FORG;
using Domain.Entities.Commons;
using Domain.Entities.FORG;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Data.Dapper.FORG
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IConfiguration config) : base(config)
        {

        }
        public List<User> GetUser(string filter, int pageNumber, int pageSize)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                List<User> results = _cnn.Query<User>("FORG.UserGet @Filter, @Pagenumber, @Pagesize", param: new { filter, pageNumber, pageSize }).ToList();
                return results;
            }
        }
        public User FindUser(string userName, string password, string companyCode)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                User results = _cnn.Query<User>("FORG.UserLogin @UserName, @Password, @CompanyCode", param: new { UserName = userName, Password = password, CompanyCode = companyCode }).FirstOrDefault();
                return results;
            }
        }
        public List<Base> GetUsers()
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                List<Base> results = new List<Base>();
                List<Base> result = _cnn.Query<Base>("Select UserId AS id,UserName AS text from FORG.[User]").ToList();
                return result;
            }
        }
    }
}