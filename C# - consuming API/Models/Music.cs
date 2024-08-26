using System.Text.Json.Serialization;

namespace C____consuming_API.Models;

internal class Music
{
    [JsonPropertyName("song")]
    public string? Names { get; set; }

    [JsonPropertyName("artist")]
    public string? Artists { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Durations { get; set; }

    [JsonPropertyName("genre")]
    public string? Genres { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Artist: {Artists}");
        Console.WriteLine($"Name: {Names}");
        Console.WriteLine($"Duration: {Durations / 1000}");
        Console.WriteLine($"Genre: {Genres}");
    }

}

