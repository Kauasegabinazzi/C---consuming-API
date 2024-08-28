using C____consuming_API.Models;
using System.Linq;

namespace C____consuming_API.Filters;

internal class LinqOrder
{
    public static void ShowArtistListOrder(List<Music> songs)
    {
        var artists = songs.OrderBy(song => song.Artists).Select(song => song.Artists).Distinct().ToList();

        foreach (var artist in artists)
        {
            Console.WriteLine(artist);
        }
    }
}

