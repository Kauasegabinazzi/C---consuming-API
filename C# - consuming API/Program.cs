using (HttpClient client = new HttpClient())
{
    #region Principal

    //try
    //{
    //    string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

    //    Console.WriteLine(response);
    //}
    //catch (Exception ex) {
    //    Console.WriteLine(ex);
    //}

    #endregion

    #region

    //try
    //{
    //    for (int i = 3; i >= 0; i--)
    //    {
    //        Console.WriteLine($"{10 / i}");
    //    }
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"Tivemos um problema: {ex.Message}");
    //}

    #endregion

    #region Primeiro Desafios

    #region 1

    try
    {
        string response = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");

        Console.WriteLine(response);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }

    #endregion

    #region 2

    #endregion

    #endregion
}

