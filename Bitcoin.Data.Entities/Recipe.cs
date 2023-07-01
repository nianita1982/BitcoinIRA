using System.ComponentModel.DataAnnotations;

namespace Bitcoin.Data.Entities
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal? TotalTax { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? Total { get; set; }
        public List<RecipeIngredient> RecipeIngredients { get; set; }
    }
}
