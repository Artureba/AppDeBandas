using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuMostrarBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas!");
        //for(int i = 0; i < listaDasBandas.Count; i++)
        //{
        //Console.WriteLine($"Banda: {listaDasBandas[i]}");
        //}

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao Menu Principal!");
        Console.ReadKey();
        Console.Clear();
    }
}
