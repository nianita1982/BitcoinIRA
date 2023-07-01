using Bitcoin.Data.Entities;
using Bitcoin.Data.Model;
using Bitcoin.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Bitcoin.Data.Repository
{
    public class Recipe : IBasicTransactions<Entities.Recipe>
    {
        private readonly BitcoinDbContext _context;
        public Recipe(BitcoinDbContext context)
        {
            _context = context;
        }
        public void Add(Entities.Recipe item)
        {
            _context.Add(item);
        }

        public IEnumerable<Entities.Recipe> GetAll()
        {
            return _context.Recipes.Include(r => r.RecipeIngredients).ThenInclude(r => r.Ingredient).ToList();
        }

        public void Update(Entities.Recipe item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges(true);

        }
    }
}
