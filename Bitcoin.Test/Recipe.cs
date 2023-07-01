using Bitcoin.Data.Repository.IRepository;
using Moq;

namespace Bitcoin.Test
{
    public class Recipe
    {
        MoqRecipeRepository _moqRecipeRepository = new MoqRecipeRepository();

        [Fact]
        public void CalculateRecipeTest()
        {
            //Arrange
            var mockRepo = new Mock<IBasicTransactions<Data.Entities.Recipe>>();
            mockRepo.Setup(repo => repo.GetAll()).Returns(_moqRecipeRepository.GetRecipes());
            Business.Recipe recipeBusiness = new Business.Recipe(mockRepo.Object);
            //Act
            var result = recipeBusiness.CalculateRecipesCost();
            //Asert11
            foreach (var recipe in result)
            {
                Assert.NotNull(recipe.Total);
                Assert.NotNull(recipe.TotalDiscount);
                Assert.NotNull(recipe.TotalTax);
            }
        }
    }
}