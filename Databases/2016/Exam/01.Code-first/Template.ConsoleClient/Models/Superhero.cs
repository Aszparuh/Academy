using Newtonsoft.Json;
using System.Collections.Generic;
using Template.Models;

namespace Template.ConsoleClient.Models
{
    public class Superhero
    {
        public string Name { get; set; }

        public string SecretIdentity { get; set; }

        public Alignment Alignment { get; set; }

        public string Story { get; set; }

        public City City { get; set; }

        [JsonProperty("powers")]
        public List<string> Powers { get; set; }

        public List<string> Fractions { get; set; }
    }
}
