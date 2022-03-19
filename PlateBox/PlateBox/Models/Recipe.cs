using Newtonsoft.Json;
using System.Collections.Generic;

namespace PlateBox.Models
{
    public class Recipe
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("steps")]
        public List<Recipes> Steps { get; set; }

        [JsonProperty("backgroundImage")]
        public string BackgroundImage { get; set; }

        [JsonProperty("thumbnailImage")]
        public string ThumbnailImage { get; set; }

        [JsonProperty("ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }



}
