using Dapper;
using Data.Dapper.Commons;
using Domain.Contracts;
using Domain.Entities.Commons;
using Domain.Entities.FSYS;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Data.Dapper
{
    public class MenuRepository : BaseRepository<Menu>, IMenuRepository
    {
        public MenuRepository(IConfiguration config) : base(config)
        {

        }
        public List<MenuGroup> GetAllMenu()
        {
            List<MenuGroup> menuDto;
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                List<Menu> menuHead = GetAll().ToList();
                menuDto = menuHead.Where(l => l.ParentId == null).OrderBy(l => l.ViewOrder)
                   .Select(l => new MenuGroup
                   {
                       Children = GetChildren(menuHead, l.MenuId),
                       MenuId = l.MenuId,
                       Text = l.Text,
                       Link = l.Link,
                       Icon = l.Icon
                   }).ToList();
                return menuDto;
            }
        }

       
        public List<Menu> GetChildren(List<Menu> Menu, long? parentId)
        {
            return Menu.Where(l => l.ParentId == parentId).OrderBy(l => l.ViewOrder)
                .Select(l => new Menu
                {
                    MenuId = l.MenuId,
                    Text = l.Text,
                    ParentId = l.ParentId,
                    ViewOrder = l.ViewOrder,
                    children = GetChildren(Menu, l.MenuId),
                    Link = l.Link,
                    Icon = l.Icon
                }).ToList();
        }

        public List<Tree<Menu>> GetAllMenuTree()
        {
            List<Tree<Menu>> menuDto;
            using (IDbConnection _cnn = Connection)
            {
                _cnn.Open();
                List<Tree<Menu>> menuHead = _cnn.Query<Tree<Menu>>("select MenuId as id,Text,ParentId From FSYS.Menu").ToList(); //GetAll().ToList();
                menuDto = menuHead.Where(l => l.ParentId == null)
                   .Select(l => new Tree<Menu>
                   {
                       Children = GetChildrenTree(menuHead, l.id),
                       id = l.id,
                       Text = l.Text
                   }).ToList();
                return menuDto;
            }
        }
        public List<Tree<Menu>> GetChildrenTree(List<Tree<Menu>> Menu, long? parentId)
        {
            return Menu.Where(l => l.ParentId == parentId)
                .Select(l => new Tree<Menu>
                {
                    id = l.id,
                    Text = l.Text,
                    ParentId = l.ParentId,
                    Children = GetChildrenTree(Menu, l.id)
                }).ToList();
        }

    }
}
