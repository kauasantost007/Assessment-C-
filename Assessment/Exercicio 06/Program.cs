using Exercicio06.Models;
namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria um objeto da classe Aluno
            Aluno aluno = new Aluno();

            aluno.Nome = "Kauã";
            aluno.Matricula = "123456";
            aluno.Curso = "Engenharia de Software";
            aluno.MediaNotas = 8.5;

            Console.WriteLine("=== DADOS DO ALUNO ===");

            aluno.ExibirDados();

            Console.WriteLine("Situação: " + aluno.VerificarAprovacao());
        }
    }
}