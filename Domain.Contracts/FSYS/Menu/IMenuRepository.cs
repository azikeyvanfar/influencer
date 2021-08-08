using Domain.Contracts.Commons;
using Domain.Entities.Commons;
using Domain.Entities.FSYS;
using System.Collections.Generic;

namespace Domain.Contracts
{
    public interface IMenuRepository : IBaseRepository<Menu>
    {
        List<MenuGroup> GetAllMenu();
        List<Tree<Menu>> GetAllMenuTree();
    }
}
