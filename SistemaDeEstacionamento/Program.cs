using System.Globalization;
using Veiculos.Model;

namespace SistemaDeEstacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                              "Digite o preço inicial:");
            double precoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Agora digite o preço por hora:");
            double precoPorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Estacionamento e = new Estacionamento(precoInicial, precoPorHora);

            bool exibirMenu = false;

            while (exibirMenu == false)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Remover veículo");
                Console.WriteLine("3 - Listar veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        e.AdicionarVeiculo();
                        break;

                    case "2":
                        e.RemoverVeiculo();
                        break;

                    case "3":
                        e.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa se encerrou");
        }
    }
}