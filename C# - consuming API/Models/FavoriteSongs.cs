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
            nome = Name,
            musicas = FavoriteSongsList
        });
        string nomeDoArquivo = $"musicas-favoritas-{Name}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine("O arquivo Json foi criado com sucesso!");
    }

    public void GerarDocumentoTXTComAsMusicasFavoritas()
    {
        string nomeDoArquivo = $"musicas-favoritas-{Name}.txt";
        using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
        {
            arquivo.WriteLine($"Músicas favoritas do {Name}\n");
            foreach (var musica in FavoriteSongsList)
            {
                arquivo.WriteLine($"- {musica.Names}");
            }
        }
        Console.WriteLine("txt gerado com sucesso!");
    }
}

