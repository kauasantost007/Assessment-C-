using System.IO;
using Exercicio11.Models;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("[1] - Adicionar novo contato");
                Console.WriteLine("[2] - Listar contatos cadastrados");
                Console.WriteLine("[3] - Sair");
                Console.Write("Escolha uma opção: ");

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: opção inválida!");
                    continue;
                }
                if (opcao == 1)
                {
                    AdicionarContato();
                }
                else if (opcao == 2)
                {
                    ListarContatos();
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

            try
            {
                using (StreamWriter escritor = File.AppendText("contatos.txt"))
                {
                    escritor.WriteLine(
                        contato.Nome + "," +
                        contato.Telefone + "," +
                        contato.Email);
                }
                Console.WriteLine("Contato cadastrado com sucesso!");
            }
            catch (IOException)
            {
                Console.WriteLine("Erro ao salvar o contato!");
            }
        }
        public static void ListarContatos()
        {
            if (!File.Exists("contatos.txt"))
            {
                Console.WriteLine("Nenhum contato cadastrado.");
                return;
            }
            try
            {
                using (StreamReader leitor = new StreamReader("contatos.txt"))
                {
                    if (leitor.EndOfStream)
                    {
                        Console.WriteLine("Nenhum contato cadastrado.");
                        return;
                    }
                    Console.WriteLine("\n=== CONTATOS CADASTRADOS ===");

                    while (!leitor.EndOfStream)
                    {
                        string linha = leitor.ReadLine();
                        string[] dados = linha.Split(',');

                        if (dados.Length == 3)
                        {
                            Console.WriteLine(
                                "Nome: " + dados[0] +
                                " | Telefone: " + dados[1] +
                                " | Email: " + dados[2]);
                        }
                        else
                        {
                            Console.WriteLine("Registro inválido!");
                        }
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Erro ao ler os contatos!");
            }
        }
    }
}