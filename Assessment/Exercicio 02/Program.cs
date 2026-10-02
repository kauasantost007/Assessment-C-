namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nomeCifrado;

            Console.Write("Digite seu nome completo: ");
            nome = Console.ReadLine();

            nomeCifrado = CodificarNome(nome);

            Console.WriteLine("Nome original: " + nome);
            Console.WriteLine("Nome cifrado: " + nomeCifrado);
        }
        public static string CodificarNome(string nome)
        {
            // Transforma o nome em um array de caracteres
            char[] caracteres = nome.ToCharArray();

            // Percorre todas as letras do nome
            for (int i = 0; i < caracteres.Length; i++)
            {
                // Verifica se a letra é maiúscula
                if (caracteres[i] >= 'A' && caracteres[i] <= 'Z')
                {
                    // Descobre a posição da letra e avança 2 posições
                    caracteres[i] = (char)('A' + (caracteres[i] - 'A' + 2) % 26);
                }
                // Verifica se a letra é minúscula
                else if (caracteres[i] >= 'a' && caracteres[i] <= 'z')
                {
                    // Faz o mesmo cálculo de antes mas pra letras minúsculas
                    caracteres[i] = (char)('a' + (caracteres[i] - 'a' + 2) % 26);
                }
            }
            // Transforma o array em texto
            return new string(caracteres);
        }
    }
}