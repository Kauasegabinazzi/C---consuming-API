using C____consuming_API;

using (HttpClient client = new HttpClient())
{
    #region Principal

    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        Console.WriteLine(response);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }

    #endregion

    #region

    try
    {
        for (int i = 3; i >= 0; i--)
        {
            Console.WriteLine($"{10 / i}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Tivemos um problema: {ex.Message}");
    }

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

    try
        {
            Console.Write("Write your first number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Write your second number: ");
        int n2 = int.Parse(Console.ReadLine());

        int result = n / n2;
        Console.WriteLine($"result: {result}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine(ex);
    }

    #endregion

    #region 3

    try
    {
        List<int> numbers = new List<int> { 10, 7, 8 };
        Console.WriteLine($"Elemento no índice 5: {numbers[6]}");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }

    #endregion

    #region 4

    try
    {
        myClass objetoNulo = null;
        objetoNulo.MyMethod();
    }
    catch (NullReferenceException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }

    #endregion

    #endregion

    #region

    string resposta = await client.GetStringAsync("https://anapioficeandfire.com/api/books/1");
    Console.WriteLine(resposta);

    #endregion
}

