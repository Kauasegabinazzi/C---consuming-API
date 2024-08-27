using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace C____consuming_API.Models
{
    internal class Country
    {
        [JsonPropertyName("nome")]
        public string? Name { get; set; }
        [JsonPropertyName("capital")]
        public string? Capital { get; set; }
        [JsonPropertyName("populacao")]
        public int? Population { get; set; }
        [JsonPropertyName("continente")]
        public string? Continent { get; set; }
        [JsonPropertyName("idioma")]
        public string? Language { get; set; }
        public string Info => $"Pais: {Name} - Capital: {Capital} - Populacao: {Population}";
    }
}
