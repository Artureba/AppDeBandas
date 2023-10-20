class Podcast
{
    private List<Episodio> episodios = new();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpsodios => episodios.Count;

    public void AdicionarEpsodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nPoscast {Nome} apresentado por {Host}!\n");
        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"\nEste podcast possui {TotalEpsodios} episodios!\n");
    }
}