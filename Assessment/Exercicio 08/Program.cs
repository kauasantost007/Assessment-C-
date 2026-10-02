using Exercicio08.Models;

namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = "Carlos";
            funcionario.Cargo = "Atendente";
            funcionario.SalarioBase = 3000;

            Gerente gerente = new Gerente();

            gerente.Nome = "Kauã";
            gerente.Cargo = "Gerente";
            gerente.SalarioBase = 5000;

            Console.WriteLine("=== FUNCIONÁRIO ===");
            Console.WriteLine("Nome: " + funcionario.Nome);
            Console.WriteLine("Cargo: " + funcionario.Cargo);
            Console.WriteLine("Salário: R$ " + funcionario.SalarioBase.ToString("F2"));

            Console.WriteLine("\n=== GERENTE ===");
            Console.WriteLine("Nome: " + gerente.Nome);
            Console.WriteLine("Cargo: " + gerente.Cargo);
            Console.WriteLine("Salário com bônus: R$ " + gerente.CalcularSalario().ToString("F2"));
        }
    }
}