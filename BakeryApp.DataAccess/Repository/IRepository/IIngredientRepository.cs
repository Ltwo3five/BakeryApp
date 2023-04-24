using BakeryApp.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.DataAccess.Repository.IRepository
{
    public  interface IIngredientRepository : IRepository<Ingredient>
    {
        Task<IEnumerable<Ingredient>> GetAllIngredientsAync();
        Task<Ingredient> GetIngredientByIdAsync(Guid ingredient);

        void update(Ingredient recipe);
        Task<IEnumerable<RecipeIngredient>> FindRecipeIngredientAsync(Guid ingredient);
    }
}
