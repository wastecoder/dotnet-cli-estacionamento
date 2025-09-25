using DesafioEstacionamento.Services;

namespace DesafioEstacionamento.UI;

public class Menu
{
    private readonly EstacionamentoService _service;

    public Menu(EstacionamentoService service)
    {
        _service = service;
    }

    public void Exibir()
    {
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
                    Console.WriteLine("\n>>> Digite a placa do veículo para estacionar:");
                    string placaCadastrar = Console.ReadLine() ?? "";
                    Console.WriteLine(_service.CadastrarVeiculo(placaCadastrar));
                    break;

                case "2":
                    Console.WriteLine("\n>>> Digite a placa do veículo para remover:");
                    string placaRemover = Console.ReadLine() ?? "";

                    Console.WriteLine("\n>>> Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int horas = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(_service.RemoverVeiculo(placaRemover, horas));
                    break;

                case "3":
                    Console.WriteLine(_service.ListarVeiculos());
                    break;

                case "4":
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine(">>> Opção inválida, tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione enter para continuar");
            Console.ReadLine();
        }

        Console.WriteLine("O programa se encerrou");
    }
}
