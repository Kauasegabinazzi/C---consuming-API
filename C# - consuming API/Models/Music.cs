using System.Text.Json.Serialization;

namespace C____consuming_API.Models;

internal class Music
{
    private string[] keyList = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };



    [JsonPropertyName("song")]
    public string? Names { get; set; }

    [JsonPropertyName("artist")]
    public string? Artists { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Durations { get; set; }

    [JsonPropertyName("genre")]
    public string? Genres { get; set; }

    [JsonPropertyName("year")]
    public string? YearsString { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string keyString
    {
        get
        {
            return this.keyList[Key];
        }
    }

    public int Years
    {
        get
        {
            return int.Parse(YearsString!);
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Artist: {Artists}");
        Console.WriteLine($"Name: {Names}");
        Console.WriteLine($"Duration: {Durations / 1000}");
        Console.WriteLine($"Genre: {Genres}");
        Console.WriteLine($"Key: {keyString}");
    }

}

