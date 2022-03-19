using Newtonsoft.Json;
using System;
using System.Text;

namespace PlateBox.Models
{


    public class Recipes
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

    }



}
