using System.Collections.Generic;
using MyRecipeStorage.Models;

namespace MyRecipeStorage.Services
{
    public interface IRecipeService
    {
        IEnumerable<RecipeMin> SearchForRecipes(string q, string category);

    }
}
