namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int numeroSecreto = aleatorio.Next(1, 51);
            int tentativas = 0;

            Console.WriteLine("Tente adivinhar um número entre 1 e 50.");
            Console.WriteLine("Você possui 5 tentativas.");

            while (tentativas < 5)
            {
                int numero;

                Console.Write("\nDigite um número: ");

                try
                {
                    numero = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: digite um número válido!");
                    continue;
                }
                if (numero < 1 || numero > 50)
                {
                    Console.WriteLine("Erro: o número deve estar entre 1 e 50!");
                    continue;
                }
                tentativas++;

                if (numero == numeroSecreto)
                {
                    Console.WriteLine("Parabéns! Você acertou!");
                    return;
                }
                else if (numero < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior!");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor!");
                }
                Console.WriteLine("Tentativas restantes: " + (5 - tentativas));
            }
            Console.WriteLine("\nSuas tentativas acabaram!");
            Console.WriteLine("O número secreto era: " + numeroSecreto);
        }
    }
}