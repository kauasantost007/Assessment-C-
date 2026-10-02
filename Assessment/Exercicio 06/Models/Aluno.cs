namespace Exercicio06.Models
{
    internal class Aluno
    {
        public string Nome;
        public string Matricula;
        public string Curso;
        public double MediaNotas;

        // Exibe as informações do aluno
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Matrícula: " + Matricula);
            Console.WriteLine("Curso: " + Curso);
            Console.WriteLine("Média: " + MediaNotas);
        }

        // Verifica se o aluno foi aprovado
        public string VerificarAprovacao()
        {
            if (MediaNotas >= 7)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}