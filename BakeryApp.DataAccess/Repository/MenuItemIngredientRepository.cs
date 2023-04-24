using BakeryApp.DataAccess.IRepository;
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
    public class MenuItemIngredientRepository : Repository<MenuItemIngredient>, IMenuItemIngredientRepository
    {
        private readonly BakeryContext _db;
        public DbSet<MenuItemIngredient> dbSet;
        private readonly IUnitOfWork _unitOfWork;

        public MenuItemIngredientRepository(BakeryContext db) : base(db)
        {
            _db = db;
            dbSet = _db.Set<MenuItemIngredient>();
            _unitOfWork = new UnitOfWork(db);


        }

        public Task<IEnumerable<MenuItemIngredient>> GetAllMenuItemIngredientAync()
        {
            throw new NotImplementedException();
        }

        public Task<MenuItemIngredient> GetMenuItemIngredienteByIdAsync(Guid menuItemIngredient)
        {
            throw new NotImplementedException();
        }

        public void update(MenuItemIngredient recipe)
        {
            throw new NotImplementedException();
        }
    }
}
