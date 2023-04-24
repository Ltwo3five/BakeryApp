using System.ComponentModel.DataAnnotations;

namespace BakeryApp.Model.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public int? CategoryId { get; set; }
        public string? Instructions { get; set; }

        public IEnumerable<MenuItemRecipes>? MenuItemRecipes { get; set; }
        public IEnumerable<MenuItemIngredient>? MenuItemIngredients { get; set; }


    }
}
