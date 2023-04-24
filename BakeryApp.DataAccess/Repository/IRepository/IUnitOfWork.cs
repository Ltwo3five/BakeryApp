using BakeryApp.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.DataAccess.IRepository
{
    public interface IUnitOfWork
    {
       
        IIngredientRepository Ingredient { get; }
        IMenuItemRepository MenuItem { get; }  
        IRecipeIngredientRepository RecipeIngredient { get;}    
        IRecipeRepository Recipe { get; }
        void Save();


    }
}
