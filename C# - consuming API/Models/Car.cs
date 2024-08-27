using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace C____consuming_API.Models
{
    internal class Car
    {
        [JsonPropertyName("marca")]
        public string? Mark { get; set; }
        [JsonPropertyName("modelo")]
        public string? Model { get; set; }
        [JsonPropertyName("ano")]
        public int? Year { get; set; }
        [JsonPropertyName("tipo")]
        public string? Type { get; set; }

        public string Info => $"Carro {Mark} {Model} {Year} {Type}";

    }
}
