using System.ComponentModel.DataAnnotations;

namespace BakeryApp.Model.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public string? Instructions { get; set; }
        public IEnumerable<RecipeIngredient>? RecipeIngredients { get; set; }
        public int CategoryId { get; set; }
        virtual public Category? Category { get; set; }

        public IEnumerable<MenuItemRecipes>? MenuItemRecipes { get; set; }



    }
}
