using Bitcoin.Business;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;

namespace Bitcoint.Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRecipe<Bitcoin.Data.Entities.Recipe> _recipe;

        public HomeController(IRecipe<Bitcoin.Data.Entities.Recipe> recipe)
        {
            _recipe = recipe;
        }

        public IActionResult Index()
        {
            List<Bitcoin.Data.Entities.Recipe> recipesCalculated = _recipe.CalculateRecipesCost().ToList();
            return View(recipesCalculated);
        }
    }
}