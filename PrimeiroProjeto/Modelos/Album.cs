namespace PrimeiroProjeto.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public List<Musica> Musicas => musicas;

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Musicas do Album {Nome}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");  
        }
        Console.WriteLine($"\nPara ouvir o album todo voce precisa de {DuracaoTotal} seg!");
    }
}