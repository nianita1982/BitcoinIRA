using Bitcoin.Data.Entities;
using Bitcoin.Utils;
using Microsoft.EntityFrameworkCore;

namespace Bitcoin.Data.Model
{
    public class BitcoinDbContext : DbContext
    {
        public BitcoinDbContext(DbContextOptions<BitcoinDbContext> options) : base(options) { }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id = 1,
                    Name = "Garlic",
                    Cost = 0.67m,
                    IsOrganic = true,
                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.clover),
                    Type = (int)EnumTypeIngredient.Produce
                },
                new Ingredient
                {
                    Id = 2,
                    Name = "Lemon",
                    Cost = 2.03m,
                    IsOrganic = false,
                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.unit),
                    Type = (int)EnumTypeIngredient.Produce
                },
                new Ingredient
                {
                    Id = 3,
                    Name = "Corn",
                    Cost = 0.87m,
                    IsOrganic = false,
                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.cup),
                    Type = (int)EnumTypeIngredient.Produce
                },
                new Ingredient
                {
                    Id = 4,
                    Name = "Chicken",
                    Cost = 2.19m,
                    IsOrganic = false,
                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.prey),
                    Type = (int)EnumTypeIngredient.Meat
                },
                new Ingredient
                {
                    Id = 5,
                    Name = "Bacon",
                    Cost = 0.24m,
                    IsOrganic = false,
                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.slice),
                    Type = (int)EnumTypeIngredient.Meat
                },
                new Ingredient
                {
                    Id = 6,
                    Name = "Pasta",
                    Cost = 0.31m,
                    IsOrganic = false,
                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.ounce),
                    Type = (int)EnumTypeIngredient.Pantry
                },
                new Ingredient
                {
                    Id = 7,
                    Name = "Olive Oil",
                    Cost = 1.92m,
                    IsOrganic = true,
                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.cup),
                    Type = (int)EnumTypeIngredient.Pantry
                },
                new Ingredient
                {
                    Id = 8,
                    Name = "Vinegar",
                    Cost = 1.26m,
                    IsOrganic = false,
                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.cup),
                    Type = (int)EnumTypeIngredient.Pantry
                },
                new Ingredient
                {
                    Id = 9,
                    Name = "Salt",
                    Cost = 0.16m,
                    IsOrganic = false,
                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.teaspoon),
                    Type = (int)EnumTypeIngredient.Pantry
                },
                new Ingredient
                {
                    Id = 10,
                    Name = "Pepper",
                    Cost = 0.17m,
                    IsOrganic = false,
                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.teaspoon),
                    Type = (int)EnumTypeIngredient.Pantry
                }
            );

            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    Id = 1,
                    Name = "1"
                },
                new Recipe
                {
                    Id = 2,
                    Name = "2"
                },
                new Recipe
                {
                    Id = 3,
                    Name = "3"
                }
            );

            modelBuilder.Entity<RecipeIngredient>().HasData(
                new RecipeIngredient
                {
                    Id = 1,
                    Amount = 1,
                    IngredientId = 1,
                    RecipeId = 1
                },
                new RecipeIngredient
                {
                    Id = 2,
                    Amount = 1,
                    IngredientId = 2,
                    RecipeId = 1
                },
                new RecipeIngredient
                {
                    Id = 3,
                    Amount = 0.75m,
                    IngredientId = 7,
                    RecipeId = 1
                },
                new RecipeIngredient
                {
                    Id = 4,
                    Amount = 0.75m,
                    IngredientId = 9,
                    RecipeId = 1
                },
                new RecipeIngredient
                {
                    Id = 5,
                    Amount = 0.5m,
                    IngredientId = 10,
                    RecipeId = 1
                },
                new RecipeIngredient
                {
                    Id = 6,
                    Amount = 1m,
                    IngredientId = 1,
                    RecipeId = 3
                },
                new RecipeIngredient
                {
                    Id = 7,
                    Amount = 4m,
                    IngredientId = 3,
                    RecipeId = 3
                },
                new RecipeIngredient
                {
                    Id = 8,
                    Amount = 4m,
                    IngredientId = 5,
                    RecipeId = 3
                },
                new RecipeIngredient
                {
                    Id = 9,
                    Amount = 8m,
                    IngredientId = 6,
                    RecipeId = 3
                },
                new RecipeIngredient
                {
                    Id = 10,
                    Amount = 0.33m,
                    IngredientId = 7,
                    RecipeId = 3
                },
                new RecipeIngredient
                {
                    Id = 11,
                    Amount = 1.25m,
                    IngredientId = 9,
                    RecipeId = 3
                },
                new RecipeIngredient
                {
                    Id = 12,
                    Amount = 0.75m,
                    IngredientId = 10,
                    RecipeId = 3
                },
                new RecipeIngredient
                {
                    Id = 13,
                    Amount = 1m,
                    IngredientId = 1,
                    RecipeId = 2
                },
                new RecipeIngredient
                {
                    Id = 14,
                    Amount = 4m,
                    IngredientId = 4,
                    RecipeId = 2
                },
                new RecipeIngredient
                {
                    Id = 15,
                    Amount = 0.5m,
                    IngredientId = 7,
                    RecipeId = 2
                },
                new RecipeIngredient
                {
                    Id = 16,
                    Amount = 0.5m,
                    IngredientId = 8,
                    RecipeId = 2
                }

            );
        }

    }
}
