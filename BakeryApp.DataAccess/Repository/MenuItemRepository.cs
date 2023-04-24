using BakeryApp.DataAccess.Repository.IRepository;
using BakeryApp.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.DataAccess.Repository
{
    public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
    {
        private readonly BakeryContext _db;
        public DbSet<MenuItem> dbSet;

        public MenuItemRepository(BakeryContext db) : base(db)
        {
            _db = db; 
            dbSet = _db.Set<MenuItem>();
           
        }

        public void update(MenuItem menuItem)
        {
           _db.MenuItems.Update(menuItem);
        }
    }
}
