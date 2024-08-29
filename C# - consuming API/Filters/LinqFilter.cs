using C____consuming_API.Models;

namespace C____consuming_API.Filters;

internal class LinqFilter
{
    public static void GenderFilters(List<Music> songs)
    {
        var allGender = songs.Select(gender => gender.Genres).Distinct().ToList();

        foreach (var gender in allGender)
        {
            Console.WriteLine(gender);
        }
    }

    public static void ArtistForGenderFilter(List<Music> songs, string gender)
    {
        var artists = songs.Where(song => song.Genres!.Contains(gender)).Select(song => song.Artists).Distinct().ToList();

        foreach (var artist in artists)
        {
            Console.WriteLine(artist);
        }

    }

    public static void SongsOfArtistsFilter(List<Music> songs, string artist)
    {
        var songsFilter = songs.Where(song => song.Artists!.Equals(artist)).ToList();

        foreach (var song in songsFilter)
        {
            Console.WriteLine(song.Names);
        }
    }

    public static void FiltrarMusicasPeloAno(List<Music> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Years == ano)
            .OrderBy(musicas => musicas.Names) // ordena as músicas pelo nome
    .Select(musicas => musicas.Names) // seleciona apenas o nome das músicas
            .Distinct() // remove as duplicidades
            .ToList(); // converte o resultado em uma lista

        Console.WriteLine($"Músicas de {ano}");
        foreach (var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}

