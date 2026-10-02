using Exercicio12.Models;
using System.IO;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("\n=== GERENCIADOR DE CONTATOS ===");
                Console.WriteLine("[1] - Adicionar contato");
                Console.WriteLine("[2] - Listar contatos");
                Console.WriteLine("[3] - Sair");
                Console.Write("Escolha uma opção: ");

                int.TryParse(Console.ReadLine(), out opcao);

                if (opcao == 1)
                {
                    AdicionarContato();
                }
                else if (opcao == 2)
                {
                    List<Contato> contatos = LerContatos();

                    if (contatos.Count == 0)
                    {
                        Console.WriteLine("Nenhum contato cadastrado.");
                        continue;
                    }
                    Console.WriteLine("\nEscolha o formato:");
                    Console.WriteLine("[1] - Markdown");
                    Console.WriteLine("[2] - Tabela");
                    Console.WriteLine("[3] - Texto Puro");
                    Console.Write("Opção: ");

                    int formato = int.Parse(Console.ReadLine());

                    ContatoFormatter formatador;

                    if (formato == 1)
                    {
                        formatador = new MarkdownFormatter();
                    }
                    else if (formato == 2)
                    {
                        formatador = new TabelaFormatter();
                    }
                    else if (formato == 3)
                    {
                        formatador = new RawTextFormatter();
                    }
                    else
                    {
                        Console.WriteLine("Formato inválido!");
                        continue;
                    }
                    formatador.ExibirContatos(contatos);
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Encerrando programa...");
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
        }
        public static void AdicionarContato()
        {
            Contato contato = new Contato();

            Console.Write("Nome: ");
            contato.Nome = Console.ReadLine();

            Console.Write("Telefone: ");
            contato.Telefone = Console.ReadLine();

            Console.Write("Email: ");
            contato.Email = Console.ReadLine();

            using (StreamWriter escritor = File.AppendText("contatos.txt"))
            {
                escritor.WriteLine(
                    contato.Nome + "," +
                    contato.Telefone + "," +
                    contato.Email);
            }
            Console.WriteLine("Contato cadastrado com sucesso!");
        }
        public static List<Contato> LerContatos()
        {
            List<Contato> contatos = new List<Contato>();

            if (!File.Exists("contatos.txt"))
            {
                return contatos;
            }
            using (StreamReader leitor = new StreamReader("contatos.txt"))
            {
                while (!leitor.EndOfStream)
                {
                    string linha = leitor.ReadLine();
                    string[] dados = linha.Split(',');

                    if (dados.Length == 3)
                    {
                        Contato contato = new Contato();

                        contato.Nome = dados[0];
                        contato.Telefone = dados[1];
                        contato.Email = dados[2];

                        contatos.Add(contato);
                    }
                }
            }
            return contatos;
        }
    }
}