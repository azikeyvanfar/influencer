using Dapper;
using Data.Dapper.Commons;
using Domain.Contracts.FORG;
using Domain.Entities.FORG;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Data.Dapper.FORG
{
    public class UserExtentionRepository : BaseRepository<UserExtention>, IUserExtentionRepository
    {
        public UserExtentionRepository(IConfiguration config) : base(config)
        {

        }
        public UserExtention FindUserExtention(Guid UserId)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                string query = "select * from [FORG].[UserExtention] where UserId='" + UserId + "' ";
                return _cnn.Query<UserExtention>(query).FirstOrDefault();
            }
        }
        public List<UserExtention> GetUserExtentionToken(Guid token)
        {
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                string query = "select * from [FORG].[UserExtention] where Token='" + token + "' ";
                return _cnn.Query<UserExtention>(query).ToList();
            }
        }
    }
}
