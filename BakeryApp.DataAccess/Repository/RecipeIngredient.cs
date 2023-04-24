using BakeryApp.DataAccess.Repository.IRepository;
using BakeryApp.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.DataAccess.Repository
{
    public class RecipeIngredientRepository : Repository<RecipeIngredient>, IRecipeIngredientRepository
    {

        private readonly BakeryContext _db;
        public DbSet<RecipeIngredient> dbSet;
        public RecipeIngredientRepository(BakeryContext db) : base(db)
        {
            _db = db;
            dbSet = _db.Set<RecipeIngredient>();
        }

        public void update(RecipeIngredient recipeIngredient)
        {
            dbSet.Update(recipeIngredient);
           
        }
    }
}
