using Plaints.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plaints.DataAccess
{
    internal class RecipeRepository : IRecipeRepository
    {
        private readonly List<Recipe> _recipes;
        public RecipeRepository()
        {
            _recipes = new List<Recipe>()
            {
                new Recipe() { Name = "demo1", Type="Lunch", ShortDescription="sarme" },
                new Recipe() { Name = "demo2", Type="Breakfast", ShortDescription="jaja" }
            };
        }

        public List<Recipe> GetRecipeByCategory(string category)
        {
            return _recipes.Where(r=> r.Type==category).ToList();
        }
    }
}
