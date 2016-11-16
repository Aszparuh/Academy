using Newtonsoft.Json;
using System.Collections.Generic;

namespace Template.ConsoleClient.Models
{
    public class RootObject
    {
        [JsonProperty("data")]
        public List<Superhero> Heroes { get; set; }
    }
}
