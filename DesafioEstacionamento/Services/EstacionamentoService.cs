using DesafioEstacionamento.Models;

namespace DesafioEstacionamento.Services;

public class EstacionamentoService(Estacionamento estacionamento)
{
    public string CadastrarVeiculo(string placa)
    {
        var cadastrado = estacionamento.AdicionarVeiculo(placa);
        return cadastrado
            ? $">>> Veículo {placa} cadastrado com sucesso!"
            : ">>> Placa inválida. Tente novamente.";
    }

    public string RemoverVeiculo(string placa, int horas)
    {
        var valor = estacionamento.RemoverVeiculo(placa, horas);

        return valor.HasValue
            ? $">>> O veículo {placa} foi removido e o preço total foi de: R$ {valor}"
            : ">>> Desculpe, esse veículo não está estacionado aqui.";
    }

    public string ListarVeiculos()
    {
        var veiculos = estacionamento.ListarVeiculos();

        if (veiculos.Count == 0)
            return ">>> Não há veículos estacionados.";

        return ">>> Veículos estacionados:\n" + string.Join(Environment.NewLine, veiculos);
    }
}
