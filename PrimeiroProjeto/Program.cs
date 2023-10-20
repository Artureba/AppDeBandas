using PrimeiroProjeto.Menus;
using PrimeiroProjeto.Modelos;

Banda mix = new Banda("Mix");
mix.AdicionarNota(new Avaliacao(10));
mix.AdicionarNota(new Avaliacao(8));
mix.AdicionarNota(new Avaliacao(6));

Banda academia = new("Academia");

string msgBoasVindas = "Boas vindas ao Screen Sound!";
Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(mix.Nome, mix);
bandasRegistradas.Add(academia.Nome, academia);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(7, new MenuJogo());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(msgBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir a média de uma banda");
    Console.WriteLine("Digite 7 para jogar um jogo de adivinhar o número");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }
}

ExibirOpcoesDoMenu();

//Album albumDoArthur = new Album("Só as melhores");

//Musica musica1 = new Musica(mix, "Automotivo")
//{
//    Duracao = 237,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(mix, "Reflections (speed up)")
//{
//    Duracao = 351,
//    Disponivel = false,
//};

//albumDoArthur.AdicionarMusica(musica1);
//albumDoArthur.AdicionarMusica(musica2);
//mix.AdicionarAlbum(albumDoArthur);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//albumDoArthur.ExibirMusicasAlbum();
//mix.ExibirDiscografia();

//Episodio ep1 = new(1, "Técnicas de facilitação", 45);
//ep1.AdicionarConvidados("Maria");
//ep1.AdicionarConvidados("Matheus");
//Console.WriteLine(ep1.Resumo);

//Episodio ep2 = new(2, "Técnicas de aprendizado", 21);
//ep2.AdicionarConvidados("Fernanda");
//ep2.AdicionarConvidados("Lucia");
//ep2.AdicionarConvidados("Cleia");
//Console.WriteLine(ep2.Resumo);

//Podcast podcast = new("Podcast especial", "Arthur");
//podcast.AdicionarEpsodio(ep1);
//podcast.AdicionarEpsodio(ep2);
//podcast.ExibirDetalhes();