namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRÓXIMO ANIVERSÁRIO ===");
            Console.Write("Digite sua data de nascimento (DD/MM/AAAA): ");

            string textoNascimento = Console.ReadLine();
            DateTime nascimento = DateTime.Parse(textoNascimento);

            DateTime hoje = DateTime.Today;

            DateTime aniversario = nascimento.AddYears(hoje.Year - nascimento.Year);

            if (hoje > aniversario)
            {
                aniversario = aniversario.AddYears(1);
            }

            TimeSpan tempoRestante = aniversario - hoje;

            if (tempoRestante.Days < 7)
            {
                Console.WriteLine("Seu aniversário está chegando!");
                Console.WriteLine("Faltam apenas " + tempoRestante.Days + " dia(s)!");
            }
            else
            {
                Console.WriteLine("Faltam " + tempoRestante.Days + " dia(s) para seu aniversário!");
            }
        }
    }
}