using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace C____consuming_API.Models
{
    internal class Books
    {
        [JsonPropertyName("titulo")]
        public string? Title { get; set; }
        [JsonPropertyName("autor")]
        public string? Author { get; set; }
        [JsonPropertyName("ano_publicacao")]
        public int? Year { get; set; }
        [JsonPropertyName("genero")]
        public string? Gender { get; set; }

        public string TechnicalSheet => $"Titulo: {Title}\nAutor: {Author}\nAno: {Year}\nGenero: {Gender}\n\n";
    }

}
