using Domain.Contracts.Commons;
using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IUtilitiesRepository : IBaseRepository<SiteSetting>
    {
        public IList<ActionAndControllerName> AreaAndActionAndControllerNamesList();
        public IList<string> GetAllAreasNames();
        public string DataBaseRoleValidationGuid();
    }
}
