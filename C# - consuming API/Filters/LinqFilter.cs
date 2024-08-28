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

        foreach (var artist in artists) {
            Console.WriteLine(artist);
        }

    }

    public static void SongsOfArtistsFilter(List<Music> songs, string artist) {
        var songsFilter = songs.Where(song => song.Artists!.Equals(artist)).ToList();

        foreach (var song in songsFilter) {
            Console.WriteLine(song.Names);
        }
    }
}

