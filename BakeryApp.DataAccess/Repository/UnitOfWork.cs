using BakeryApp.DataAccess.IRepository;
using BakeryApp.DataAccess.Repository.IRepository;
using BakeryApp.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BakeryApp.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private BakeryContext _db;

        public IIngredientRepository Ingredient { get; private set; }
        public IMenuItemRepository MenuItem { get; private set; }
        public IRecipeIngredientRepository RecipeIngredient { get; private set; }
        public IRecipeRepository Recipe { get; private set; }

        public UnitOfWork(BakeryContext db)
        {
            _db = db;
            Ingredient = new IngredientRepository(_db);
            MenuItem = new MenuItemRepository(_db);
            Recipe = new RecipeRepository(_db);
            RecipeIngredient = new RecipeIngredientRepository(_db);
      
        }

        public void Save()
        {
            _db.SaveChanges();
        }

   
    }
}
