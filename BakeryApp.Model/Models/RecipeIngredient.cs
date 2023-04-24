using System.ComponentModel.DataAnnotations;

namespace BakeryApp.Model.Models
{
    public class RecipeIngredient
    {
        [Key]
        public int RecipeId { get; set; }
        virtual public Recipe? Recipe { get; set; }
        public int IngredientId { get; set; }
        virtual public Ingredient? Ingredient { get; set; }
        public int? Amount { get; set; }
        public string? Unit { get; set; }

    }
}
