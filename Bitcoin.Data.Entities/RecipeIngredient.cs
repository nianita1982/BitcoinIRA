using System.ComponentModel.DataAnnotations;

namespace Bitcoin.Data.Entities
{
    public class RecipeIngredient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal Amount { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

    }
}
