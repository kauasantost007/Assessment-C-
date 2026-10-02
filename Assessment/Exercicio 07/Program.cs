using Exercicio07.Models;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            conta.Titular = "Kauã";

            Console.WriteLine("Titular: " + conta.Titular);

            conta.Depositar(500);
            conta.ExibirSaldo();

            Console.WriteLine("Tentativa de saque: R$ 600,00");
            conta.Sacar(600);

            conta.Sacar(400);
            conta.ExibirSaldo();
        }
    }
}