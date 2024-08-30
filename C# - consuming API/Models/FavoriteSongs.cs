using System.Text.Json;
namespace C____consuming_API.Models;

internal class FavoriteSongs
{
    public string Name { get; set; }
    public List<Music> FavoriteSongsList;

    public FavoriteSongs(string name)
    {
        Name = name;
        FavoriteSongsList = new List<Music>(); 
    }

    public void Add(Music song)
    {
        FavoriteSongsList.Add(song);
    }

    public void Info()
    {
        Console.WriteLine(Name);
        foreach(var song in FavoriteSongsList)
        {
            Console.WriteLine(song.Names + " - " + song.Artists);
        }
        Console.WriteLine();
    }

    public void CreateFileJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            songs = FavoriteSongsList
        });
        string fileName = $"musica-favoritas-{Name}.json";

        File.WriteAllText(fileName, json);
        Console.WriteLine("Sucess" + Path.GetFullPath(fileName));
    }
}

