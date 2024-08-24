using (HttpClient client = new HttpClient())
{
    string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

    Console.WriteLine(response);
}
        