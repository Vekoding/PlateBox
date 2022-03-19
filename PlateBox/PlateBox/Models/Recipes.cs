using System;
using System.Collections.Generic;
using System.Text;

namespace PlateBox.Models
{


    public class Recipes
    {
        public string text { get; set; }

    }
    public class Ingredients
    {
        public string name { get; set; }
        public string unit { get; set; }
        public string amount { get; set; }

    }
    public class Recipe
    {
        public string id { get; set; }
        public string name { get; set; }
        public IList<Recipes> steps { get; set; }
        public string backgroundImage { get; set; }
        public string thumbnailImage { get; set; }
        public IList<Ingredients> ingredients { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public string type { get; set; }

    }
    public class Application
    {
        public IList<Recipe> recipe { get; set; }

    }

}
