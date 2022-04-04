using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.Models
{
    public class RecipeList
    {
        [JsonProperty("recipe")]
        public List<Recipe> Recipe { get; set; }
    }
}
