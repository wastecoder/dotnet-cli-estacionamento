namespace DesafioEstacionamento.Models;

public class Estacionamento
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("\n>>> Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine() ?? "";
        veiculos.Add(placa);
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("\n>>> Digite a placa do veículo para remover:");
        string placa = Console.ReadLine() ?? "";

        // Verifica se o veículo existe
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("\n>>> Digite a quantidade de horas que o veículo permaneceu estacionado:");
            
            int horasEstacionado = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = precoInicial + (precoPorHora * horasEstacionado);

            veiculos.Remove(placa);
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("\n>>> Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count > 0)
        {
            Console.WriteLine("\n>>> Os veículos estacionados são:");

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
        else
        {
            Console.WriteLine("\n>>> Não há veículos estacionados.");
        }
    }
}
