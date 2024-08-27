using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace C____consuming_API.Models
{
    internal class Movie
    {
        [JsonPropertyName("title")]
        public string? Titles { get; set; }
        [JsonPropertyName("year")]
        public string? Years { get; set; }
        [JsonPropertyName("crew")]
        public string? Cast { get; set; }
        [JsonPropertyName("imDbRating")]
        public string? Notice { get; set; }
        public string TechnicalSheet => $"\n\nTitulo: {Titles} ({Years}) - Nota: {Notice}\nElenco: [{Cast}]\n\n";
    }
}
