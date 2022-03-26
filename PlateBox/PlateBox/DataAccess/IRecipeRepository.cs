using PlateBox.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlateBox.DataAccess
{
    internal interface IRecipeRepository
    {
        List<Recipe> GetTypesOfRecipes();
        List<Recipe> GetRecipeById(int id);

        void RecipeSaved();
        Recipe GetRecipeByName(string name);
    }
}
