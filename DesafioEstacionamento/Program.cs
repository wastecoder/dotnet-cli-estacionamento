using DesafioEstacionamento.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.WriteLine("\n>>> Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\n>>> Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("+========================+");
    Console.WriteLine("|     ESTACIONAMENTO     |");
    Console.WriteLine("+========================+");
    Console.WriteLine("| 1 - Cadastrar veículo  |");
    Console.WriteLine("| 2 - Remover veículo    |");
    Console.WriteLine("| 3 - Listar veículos    |");
    Console.WriteLine("| 4 - Encerrar           |");
    Console.WriteLine("+========================+");

    Console.WriteLine(">>> Digite a sua opção:");
    opcao = Console.ReadLine() ?? "";

    switch (opcao)
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine(">>> Opção inválida, tente novamente.");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
