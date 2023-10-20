using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int qtdeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(qtdeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(Dictionary<string, Banda> bandaRegistradas)
    {
        Console.Clear();
    }
}
