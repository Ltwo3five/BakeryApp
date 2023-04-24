using BakeryApp.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.DataAccess.Repository.IRepository
{
    public interface IRecipeRepository : IRepository<Recipe>
    {
        Task<IEnumerable<Recipe>> GetAllRecipesAync();
        Task<Recipe> GetRecipeByIdAsync(Guid recipeId);

        void update(Recipe recipe);
        Task<IEnumerable<RecipeIngredient>> FindRecipeIngredientAsync(Guid recipeId);
    }
}
