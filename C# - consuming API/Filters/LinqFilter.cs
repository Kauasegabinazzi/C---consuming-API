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
}

