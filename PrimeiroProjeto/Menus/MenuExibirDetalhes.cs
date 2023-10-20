using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibir detalhes das bandas!");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            //double mediaDaBanda = bandasRegistradas[nomeDaBanda].Average();
            //Console.WriteLine($"A media da banda {nomeDaBanda} é: {mediaDaBanda}!");
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine("\n" + banda.Resumo);
            Console.WriteLine($"\nA media da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine("\nDiscografia: ");
            foreach(Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} nao foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
