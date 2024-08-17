using DesafioFundamentos.Models;

class Program
{

    static void Main(string[] args)
    {
        MenuInicial();
    }

    public static void MenuInicial()
    {
        Console.Clear();
        Console.WriteLine("Bem vindo ao estacionamento!");
        Console.WriteLine("Digite o valor inicial");
        int precoInicial = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor por hora");
        int precoPorHora = int.Parse(Console.ReadLine());

        Estacionamento estacionamento = new(precoInicial, precoPorHora);

        estacionamento.MenuSecundario();
    }


}
