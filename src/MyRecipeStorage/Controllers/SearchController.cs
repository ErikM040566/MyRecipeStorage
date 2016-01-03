using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MyRecipeStorage.Services;
using MyRecipeStorage.ViewModels.Search;

namespace MyRecipeStorage.Controllers
{
    public class SearchController : Controller
    {
        private readonly IRecipeService _recipeService;

        public SearchController()
        {
            _recipeService = new RecipeServiceDummyStorage();
        }

        public IActionResult Index(string q)
        {
            var tt = new SearchViewModel();

            var searchResult = _recipeService.SearchForRecipes(q, string.Empty);
            if (searchResult != null)
            {
               tt.ListOfRecipes = searchResult;
            }



            return View(tt);
        }
    }
}
