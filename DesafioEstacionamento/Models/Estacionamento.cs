namespace DesafioEstacionamento.Models;

public class Estacionamento(decimal precoInicial, decimal precoPorHora)
{
    private readonly List<string> _veiculos = [];


    public bool AdicionarVeiculo(string placa)
    {
        if (string.IsNullOrWhiteSpace(placa))
        {
            return false;
        }

        _veiculos.Add(placa.ToUpper());
        return true;
    }

    public decimal? RemoverVeiculo(string placa, int horasEstacionado)
    {
        var veiculo = _veiculos.FirstOrDefault(
            x => string.Equals(x, placa, StringComparison.OrdinalIgnoreCase));
        if (veiculo == null)
        {
            return null;
        }

        _veiculos.Remove(veiculo);
        return precoInicial + (precoPorHora * horasEstacionado);
    }

    public List<string> ListarVeiculos()
    {
        return _veiculos;
    }
}
