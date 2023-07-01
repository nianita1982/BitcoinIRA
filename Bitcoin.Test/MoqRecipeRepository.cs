using Bitcoin.Data.Entities;
using Bitcoin.Utils;

namespace Bitcoin.Test
{
    internal class MoqRecipeRepository
    {
        internal IEnumerable<Bitcoin.Data.Entities.Recipe> GetRecipes()
        {
            return new List<Bitcoin.Data.Entities.Recipe>()
            {
                new Bitcoin.Data.Entities.Recipe()
                {
                    Id = 1,
                    Name = "1",
                    RecipeIngredients = (new List<Bitcoin.Data.Entities.RecipeIngredient>(){
                        new Bitcoin.Data.Entities.RecipeIngredient
                        {
                            Id = 1,
                            Amount = 1,
                            IngredientId = 1,
                            RecipeId = 1,
                            Ingredient = ( new Bitcoin.Data.Entities.Ingredient()
                            {
                                    Id = 1,
                                    Name = "Garlic",
                                    Cost = 0.67m,
                                    IsOrganic = true,
                                    Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.clover),
                                    Type = (int)EnumTypeIngredient.Produce
                            })
                        },
                        new Bitcoin.Data.Entities.RecipeIngredient
                        {
                            Id = 2,
                            Amount = 1,
                            IngredientId = 2,
                            RecipeId = 1,
                            Ingredient = ( new Bitcoin.Data.Entities.Ingredient()
                            {
                                Id = 2,
                                Name = "Lemon",
                                Cost = 2.03m,
                                IsOrganic = false,
                                Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.unit),
                                Type = (int)EnumTypeIngredient.Produce
                            })
                        },
                        new Bitcoin.Data.Entities.RecipeIngredient
                        {
                            Id = 3,
                            Amount = 0.75m,
                            IngredientId = 7,
                            RecipeId = 1,
                            Ingredient = ( new Bitcoin.Data.Entities.Ingredient()
                            {
                                Id = 7,
                                Name = "Olive Oil",
                                Cost = 1.92m,
                                IsOrganic = true,
                                Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.cup),
                                Type = (int)EnumTypeIngredient.Pantry
                            })
                        },
                        new Bitcoin.Data.Entities.RecipeIngredient
                        {
                            Id = 4,
                            Amount = 0.75m,
                            IngredientId = 9,
                            RecipeId = 1,
                            Ingredient = ( new Bitcoin.Data.Entities.Ingredient()
                            {
                                Id = 9,
                                Name = "Salt",
                                Cost = 0.16m,
                                IsOrganic = false,
                                Measure = Enum.GetName(typeof(EnumTypeMeasure), EnumTypeMeasure.teaspoon),
                                Type = (int)EnumTypeIngredient.Pantry
                            })
                        }
                    })
                }
            };
        }
    }
}
