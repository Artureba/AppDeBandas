using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine("\nTchau Brigado!!!");
    }
}
