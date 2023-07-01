using System.ComponentModel.DataAnnotations;

namespace Bitcoin.Data.Entities
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsOrganic { get; set; }
        [Required]
        public int Type { get; set; }
        [Required]
        public string  Measure { get; set; }
        [Required]
        public decimal Cost { get; set; }
        public List<RecipeIngredient> RecipeIngredients { get; set; }

    }
}
