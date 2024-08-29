﻿using C____consuming_API;
using C____consuming_API.Filters;
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

        //musics[1998].ShowInfo();

        //string json = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");

        //Character margaery = JsonSerializer.Deserialize<Character>(json)!;
        //margaery.ExibirApelidosDaPersonagem();

        //LinqFilter.GenderFilters(musics);

        //LinqOrder.ShowArtistListOrder(musics);

        //LinqFilter.ArtistForGenderFilter(musics, "rock");

        //LinqFilter.SongsOfArtistsFilter(musics, "Michel Teló");

        LinqFilter.FiltrarMusicasPeloAno(musics, 2012);


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

    #region

    //    List<string> typeStrings = new List<string> { "teste", "teste1", "teste3", "teste3", "teste2"};

    //    var typeStringss = typeStrings.Distinct();

    //    foreach (var type in typeStringss)
    //    {
    //        Console.Write(type + " ");
    //    }

    //    List<string> lista1 = new List<string> { "asdsd", "teste1",  };
    //    List<string> lista2 = new List<string> { "fdsf", "teste1", };

    //    var strings = lista1.Intersect(lista2);

    //    foreach (var type in strings)
    //    {
    //        Console.Write(type + " ");
    //    }

    //    List<Books> livros = new List<Books>
    //{
    //    new Books { Title = "Aprendendo LINQ", Author = "João Silva", Year = 2005 },
    //    new Books { Title = "Programação em C#", Author = "Ana Oliveira", Year = 2010 },
    //    new Books { Title = "Algoritmos e Estruturas de Dados", Author = "Carlos Santos", Year = 1998 },
    //    new Books { Title = "Introdução à Inteligência Artificial", Author = "Mariana Costa", Year = 1900 },
    //    new Books { Title = "Design Patterns", Author = "Paulo Rocha", Year = 1900 }
    //};

    //    var books = livros
    //        .Where(l => l.Year > 2000)
    //        .OrderBy(l => l.Title)
    //        .Select(l => l.Title);

    //    foreach (var title in books)
    //    {
    //        Console.WriteLine("Títulos de livros publicados após 2000, ordenados alfabeticamente:" + title);
    //    }

    //List<Products> produtos = new List<Products>
    //    {
    //        new Products { Name = "Laptop", Price = 1200 },
    //        new Products { Name = "Smartphone", Price = 800 },
    //    };

    //var precoMedio = produtos.Average(p => p.Price);

    //Console.WriteLine("Preço médio dos produtos: " + precoMedio);


    //List<string> words = new List<string> { "ma", "ti", "teste", "mu", "tipo" };

    //var filter = words.Where(p => p.Length > 3).OrderBy(p => p.Length);

    //Console.WriteLine("Palavras com mais de 3 caracteres, ordenadas por comprimento:");
    //foreach (var wordss in filter)
    //{
    //    Console.Write(wordss + " ");
    //}

    //List<int> number = new List<int> { 1,6,8,4,7,10,5, };

    //var par = number.Where(x => x % 2 == 0);

    //Console.WriteLine("Números Pares:");
    //foreach (var numbers in par)
    //{
    //    Console.Write(numbers + " ");
    //}

    #endregion
}

