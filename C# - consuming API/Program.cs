using C____consuming_API;
using C____consuming_API.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    #region Principal

    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        //Console.WriteLine(response);

        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;

        musics[1998].ShowInfo();

        string json = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");

        Character margaery = JsonSerializer.Deserialize<Character>(json)!;
        margaery.ExibirApelidosDaPersonagem();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }

    #endregion

    #region comentado

    //#region

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

    //#endregion

    //#region Primeiro Desafios

    //#region 1

    //try
    //{
    //    string response = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");

    //    Console.WriteLine(response);
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine(ex);
    //}

    //#endregion

    //#region 2

    //try
    //    {
    //        Console.Write("Write your first number: ");
    //    int n = int.Parse(Console.ReadLine());

    //    Console.Write("Write your second number: ");
    //    int n2 = int.Parse(Console.ReadLine());

    //    int result = n / n2;
    //    Console.WriteLine($"result: {result}");
    //}
    //catch (DivideByZeroException ex)
    //{
    //    Console.WriteLine(ex);
    //}

    //#endregion

    //#region 3

    //try
    //{
    //    List<int> numbers = new List<int> { 10, 7, 8 };
    //    Console.WriteLine($"Elemento no índice 5: {numbers[6]}");
    //}
    //catch (ArgumentOutOfRangeException ex)
    //{
    //    Console.WriteLine($"Erro: {ex.Message}");
    //}

    //#endregion

    //#region 4

    //try
    //{
    //    myClass objetoNulo = null;
    //    objetoNulo.MyMethod();
    //}
    //catch (NullReferenceException ex)
    //{
    //    Console.WriteLine($"Erro: {ex.Message}");
    //}

    //#endregion

    //#endregion

    //#region

    //string resposta = await client.GetStringAsync("https://anapioficeandfire.com/api/books/1");
    //Console.WriteLine(resposta);

    //#endregion

    //#region movie

    //try
    //{
    //    string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");

    //    var movies = JsonSerializer.Deserialize<List<Movie>>(response);
    //    foreach (var movie in movies)
    //    {
    //        Console.WriteLine(movie.TechnicalSheet);
    //    }
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"We have a probleam: {ex.Message}");
    //}

    //#endregion

    //#region

    //try
    //{
    //    string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");

    //    var coutrys = JsonSerializer.Deserialize<List<Country>>(response);
    //    foreach (var country in coutrys)
    //    {
    //        Console.WriteLine(country.Info);
    //    }
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"We have a probleam: {ex.Message}");
    //}

    //#endregion

    //#region

    //try
    //{
    //    string response = await client.GetStringAsync("https://github.com/ArthurOcFernandes/Exerc-cios-C-/raw/curso-4-aula-2/Jsons/Carros.json");

    //    var cars = JsonSerializer.Deserialize<List<Car>>(response);
    //    foreach (var car in cars)
    //    {
    //        Console.WriteLine(car.Info);
    //    }
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"We have a problem: {ex.Message}");
    //}

    //#endregion

    //#region

    //try
    //{
    //    string response = await client.GetStringAsync("https://github.com/ArthurOcFernandes/Exerc-cios-C-/raw/curso-4-aula-2/Jsons/Livros.json");

    //    var books = JsonSerializer.Deserialize<List<Books>>(response);
    //    foreach (var book in books)
    //    {
    //        Console.WriteLine(book.TechnicalSheet);
    //    }
    //}
    //catch (Exception ex)
    //{
    //    Console.WriteLine($"we have a problem: {ex.Message}");
    //}

    //#endregion

    #endregion
}

