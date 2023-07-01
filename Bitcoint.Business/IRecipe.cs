using Bitcoin.Data.Entities;

namespace Bitcoin.Business
{
    public interface IRecipe<T> where T : class
    {

        //ICollection<T>
        public IEnumerable<T> CalculateRecipesCost();
    }
}
