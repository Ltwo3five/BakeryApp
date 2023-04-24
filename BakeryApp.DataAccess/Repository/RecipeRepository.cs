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
    public class RecipeRepository : Repository<Recipe>, IRecipeRepository
    {
        private readonly BakeryContext _db;
        public DbSet<Recipe> dbSet;
        private readonly IUnitOfWork _unitOfWork;

        public RecipeRepository(BakeryContext db) : base(db)
        {
            _db = db;
            dbSet = _db.Set<Recipe>();
            _unitOfWork= new UnitOfWork(db);


        }

        public async Task<IEnumerable<Recipe>> GetAllRecipesAync()
        {
            return await FindAll().OrderBy(x => x.Name).ToListAsync();  
        }

        public async Task<Recipe> GetRecipeByIdAsync(Guid recipeId)
        {
            return await FindByCondition(x => x.Id.Equals(recipeId)).FirstOrDefaultAsync();
        }


        public void update(Recipe recipe)
        {
            _db.Recipes.Update(recipe);
        }

        public async Task<IEnumerable<RecipeIngredient>> FindRecipeIngredientAsync(Guid recipeId)
        {
            return await _unitOfWork.RecipeIngredient.FindByCondition(x => x.RecipeId.Equals(recipeId)).ToListAsync();
        }
     
       

    }
}
