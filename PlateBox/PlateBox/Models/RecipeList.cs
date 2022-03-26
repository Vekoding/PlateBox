using Newtonsoft.Json;
using System.Collections.Generic;

namespace PlateBox.Models
{
    public class RecipeList
    {
        [JsonProperty("recipe")]
        public List<Recipe> Recipe { get; set; }
    }



}
