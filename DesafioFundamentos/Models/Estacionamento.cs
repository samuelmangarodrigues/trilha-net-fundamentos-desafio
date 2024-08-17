using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public int PrecoInicial { get; set; }
        public int PrecoPorHora { get; set; }

        private List<Veiculo> todosVeiculos = new();

        public Estacionamento(int precoInicial, int precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }




        public void AdicionarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veiculo\n");
            string placaDoveiculo = Console.ReadLine();
            Veiculo veiculo = new(placaDoveiculo);

            todosVeiculos.Add(veiculo);
            MenuSecundario();
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo que quer remover:\n");

            string placaDoveiculo = Console.ReadLine();

            Veiculo veiculo = todosVeiculos.Find(v => string.Equals(v.NumeroDaPlaca, placaDoveiculo, StringComparison.OrdinalIgnoreCase));

            VerificaSeOVeiculoExisteERemove(veiculo);

        }

        public void VerificaSeOVeiculoExisteERemove(Veiculo veiculo)
        {
            if (veiculo != null)
            {
                Console.WriteLine("Digite o tempo que seu carro ficou estacionado:\n");

                int tempoDeEstacionamento = int.Parse(Console.ReadLine());

                CalculaValorFinal(tempoDeEstacionamento);

                todosVeiculos.Remove(veiculo);

                Console.WriteLine($"Veiculo de placa {veiculo.NumeroDaPlaca} removido com sucesso!\n");
                Console.WriteLine("Aperte Enter para voltar ao menu");
                Console.ReadLine();

                MenuSecundario();

            }
            else Console.WriteLine("Veiculo nao encontrado");
        }


        public void CalculaValorFinal(int tempoDeEstacionamento)
        {


            int valorFinal = tempoDeEstacionamento * PrecoPorHora;

            Console.WriteLine($"\nValor à pagar :${valorFinal + PrecoInicial},00\n");

        }


        public void MenuSecundario()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opcao:");
            Console.WriteLine("1 - Adicionar carro");
            Console.WriteLine("2 - Listar carros");
            Console.WriteLine("3 - Remover carro");
            Console.WriteLine("4 - Encerrar");
            char opcao = char.Parse(Console.ReadLine());

            VerificaOpcao(opcao);

        }

        public void VerificaOpcao(char opcao)
        {

            switch (opcao)
            {
                case '1': AdicionarVeiculo(); break;
                case '2': ListarCarrosEstacionados(); break;
                case '3': RemoverVeiculo(); break;
                case '4': Sair(); break;
                default: MenuSecundario(); break;
            }
        }

        public static void Sair()
        {
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public void ListarCarrosEstacionados()
        {
            Console.WriteLine("Veiculos estacionados:");

            foreach (Veiculo veiculo in todosVeiculos)
            {
                Console.WriteLine(veiculo.NumeroDaPlaca);
            }

            Console.WriteLine("\nAperte Enter para voltar ao menu");
            Console.ReadLine();

            MenuSecundario();

        }
    }
}