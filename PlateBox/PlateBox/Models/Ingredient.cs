using Newtonsoft.Json;

namespace PlateBox.Models
{
    public class Ingredient
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }
    }



}
