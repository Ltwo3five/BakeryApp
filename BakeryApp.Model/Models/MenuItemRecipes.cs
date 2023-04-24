using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp.Model.Models
{
    public class MenuItemRecipes
    {
        [Key]
        public int RecipeId { get; set; }   
        public Recipe? Recipe { get; set; }
        public int MenuItemId { get; set; }
        virtual public MenuItem? MenuItem { get; set; }

    }
}
