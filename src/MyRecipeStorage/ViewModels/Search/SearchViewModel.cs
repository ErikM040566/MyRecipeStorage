using System.Collections.Generic;
using MyRecipeStorage.Models;

namespace MyRecipeStorage.ViewModels.Search
{
    public class SearchViewModel
    {
        public IEnumerable<RecipeMin> ListOfRecipes { get; set; }
    }
}
