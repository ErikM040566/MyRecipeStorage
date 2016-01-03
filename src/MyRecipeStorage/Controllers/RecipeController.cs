using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MyRecipeStorage.Services;
using MyRecipeStorage.ViewModels.Recipe;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyRecipeStorage.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;

        // GET: /<controller>/
        public RecipeController()
        {
            _recipeService = new RecipeServiceDummyStorage();
        }

        public IActionResult Index(string id)
        {
            var viewModel = new RecipeViewModel();
            var recipe =_recipeService.GetRecipe(id);
            if (recipe != null)
            {
                viewModel.Recipe = recipe;
            }
            return View(viewModel);
        }
    }
}
