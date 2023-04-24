using BakeryApp.DataAccess.IRepository;
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
    public class IngredientRepository : Repository<Ingredient>, IIngredientRepository
    {

        private readonly BakeryContext _db;
        public DbSet<Ingredient> dbSet;
        private readonly IUnitOfWork _unitOfWork;
        public IngredientRepository(BakeryContext db) : base(db)
        {
            _db = db;
            dbSet = _db.Set<Ingredient>();
            _unitOfWork = new UnitOfWork(db);
        }

        public async Task<IEnumerable<RecipeIngredient>> FindRecipeIngredientAsync(Guid recipeId)
        {
            return await _unitOfWork.RecipeIngredient.FindByCondition(x => x.RecipeId.Equals(recipeId)).ToListAsync();
        }

        public async Task<IEnumerable<Ingredient>> GetAllIngredientsAync()
        {
            return await FindAll().OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Ingredient> GetIngredientByIdAsync(Guid ingredient)
        {
            return await FindByCondition(x => x.Id.Equals(ingredient)).FirstOrDefaultAsync();
        }

        public void update(Ingredient ingredient)
        {
            _db.Ingredients.Update(ingredient);
        }
       
    }
}
