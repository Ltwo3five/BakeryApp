using BakeryApp.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.DataAccess.Repository.IRepository
{
    public interface IMenuItemIngredientRepository : IRepository<MenuItemIngredient>
    {

        Task<IEnumerable<MenuItemIngredient>> GetAllMenuItemIngredientAync();
        Task<MenuItemIngredient> GetMenuItemIngredienteByIdAsync(Guid menuItemIngredient);

        void update(MenuItemIngredient recipe);
    }
    
}
