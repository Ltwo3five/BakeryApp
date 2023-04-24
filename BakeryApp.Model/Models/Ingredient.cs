using System.ComponentModel.DataAnnotations;

namespace BakeryApp.Model.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public IEnumerable<RecipeIngredient>? RecipeIngredients { get; set; }
        public IEnumerable<MenuItemIngredient> MenuItemIngredients { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
