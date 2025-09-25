namespace DesafioEstacionamento.Models;

public class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        this.veiculos = new List<string>();
    }

    public bool AdicionarVeiculo(string placa)
    {
        if (!string.IsNullOrWhiteSpace(placa))
        {
            veiculos.Add(placa.ToUpper());
            return true;
        }
        return false;
    }

    public decimal? RemoverVeiculo(string placa, int horasEstacionado)
    {
        var veiculo = veiculos.FirstOrDefault(x => x.ToUpper() == placa.ToUpper());

        if (veiculo != null)
        {
            veiculos.Remove(veiculo);
            return precoInicial + (precoPorHora * horasEstacionado);
        }

        return null; // não encontrado
    }

    public List<string> ListarVeiculos()
    {
        return veiculos;
    }
}
