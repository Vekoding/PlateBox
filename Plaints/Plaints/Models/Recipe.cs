using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.Models
{
    public class Recipe
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("steps")]
        public List<RecipeStep> Steps { get; set; }

        [JsonProperty("backgroundImage")]
        public string BackgroundImage { get; set; }

        [JsonProperty("thumbnailImage")]
        public string ThumbnailImage { get; set; }

        [JsonProperty("ingredients")]
        public List<Ingredients> Ingredients { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }


    }
}
