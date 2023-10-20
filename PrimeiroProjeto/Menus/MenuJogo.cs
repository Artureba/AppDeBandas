using PrimeiroProjeto.Modelos;

namespace PrimeiroProjeto.Menus;

internal class MenuJogo : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.WriteLine(@"
░█████╗░██████╗░██╗██╗░░░██╗██╗███╗░░██╗██╗░░██╗███████╗  ░█████╗░
██╔══██╗██╔══██╗██║██║░░░██║██║████╗░██║██║░░██║██╔════╝  ██╔══██╗
███████║██║░░██║██║╚██╗░██╔╝██║██╔██╗██║███████║█████╗░░  ██║░░██║
██╔══██║██║░░██║██║░╚████╔╝░██║██║╚████║██╔══██║██╔══╝░░  ██║░░██║
██║░░██║██████╔╝██║░░╚██╔╝░░██║██║░╚███║██║░░██║███████╗  ╚█████╔╝
╚═╝░░╚═╝╚═════╝░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝  ░╚════╝░

███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░██╗
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗██║
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║██║
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║╚═╝
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝██╗
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝");
        Console.WriteLine("\nO jogo consiste em voce tentar acertar um número secreto entre 1 e 100!\n");


        Random aleatorio = new Random();
        int numeroSecreto = aleatorio.Next(1, 101);

        do
        {
            Console.Write("Digite um número entre 1 e 100: ");
            int chute = int.Parse(Console.ReadLine());

            if (chute == numeroSecreto)
            {
                Console.WriteLine("\n********************************");
                Console.WriteLine("Parabéns! Você acertou o número.");
                Console.WriteLine("********************************");
                break;
            }
            else if (chute < numeroSecreto)
            {
                Console.WriteLine("O número é maior.");
            }
            else
            {
                Console.WriteLine("O número é menor.");
            }

        } while (true);

        Console.WriteLine("\nO jogo acabou.Digite uma tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }
}
