using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plaints.Models
{
    public class Ingredients
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("amount")]
        public string Amount { get; set; }

    }
}
