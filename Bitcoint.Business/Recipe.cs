using Bitcoin.Data.Entities;
using Bitcoin.Data.Repository.IRepository;
using Bitcoin.Utils;

namespace Bitcoin.Business
{
    public class Recipe : IRecipe<Data.Entities.Recipe>
    {
        private readonly IBasicTransactions<Data.Entities.Recipe> _recipeRepository;

        public Recipe(IBasicTransactions<Data.Entities.Recipe> recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }
        public IEnumerable<Data.Entities.Recipe> CalculateRecipesCost()
        {
            List<Data.Entities.Recipe> recipies = _recipeRepository.GetAll().ToList();

            foreach (Data.Entities.Recipe recipe in recipies)
            {
                CalculateTax(recipe);
            }
            return recipies;
        }

        private void CalculateTax(Data.Entities.Recipe recipe)
        {
            decimal totalCostIngredients = 0;
            decimal totalTaxIngredients = 0;
            decimal totalDiscountIngredients = 0;
            foreach (RecipeIngredient recipeIngredient in recipe.RecipeIngredients)
            {
                string name = recipeIngredient.Ingredient.Name;
                bool isOrganic = recipeIngredient.Ingredient.IsOrganic;
                int type = recipeIngredient.Ingredient.Type;
                decimal costIngredient = recipeIngredient.Amount * recipeIngredient.Ingredient.Cost;
                totalCostIngredients += costIngredient;
                if (recipeIngredient.Ingredient.Type != (int)EnumTypeIngredient.Produce)
                {
                    totalTaxIngredients += costIngredient * Constant.taxRate;
                }
                if (recipeIngredient.Ingredient.IsOrganic)
                {
                    totalDiscountIngredients += costIngredient * Constant.discountRate;
                }
            }
            recipe.TotalTax = MathFunctions.RoundUp7Cents(totalTaxIngredients);
            recipe.TotalDiscount = MathFunctions.RoundUp(totalDiscountIngredients);
            recipe.Total = (totalCostIngredients + recipe.TotalTax) - recipe.TotalDiscount;
            _recipeRepository.Update(recipe);
        }
    }
}
