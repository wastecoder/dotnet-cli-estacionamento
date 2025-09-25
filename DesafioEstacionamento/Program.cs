using DesafioEstacionamento.Models;
using DesafioEstacionamento.Services;
using DesafioEstacionamento.UI;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.WriteLine("\n>>> Digite o preço inicial:");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("\n>>> Agora digite o preço por hora:");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());

var estacionamento = new Estacionamento(precoInicial, precoPorHora);
var service = new EstacionamentoService(estacionamento);
var menu = new Menu(service);

menu.Exibir();
