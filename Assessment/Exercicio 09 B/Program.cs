using System.IO;
using Exercicio09B.Models;

namespace Exercicio09B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arquivo = "estoque.txt";
            int opcao = 0;

            if (!File.Exists(arquivo))
            {
                using (StreamWriter escritor = new StreamWriter(arquivo))
                {
                }
            }
            while (opcao != 3)
            {
                Console.WriteLine("\n=== CONTROLE DE ESTOQUE ===");
                Console.WriteLine("[1] - Inserir Produto");
                Console.WriteLine("[2] - Listar Produtos");
                Console.WriteLine("[3] - Sair");
                Console.Write("Escolha uma opção: ");

                int.TryParse(Console.ReadLine(), out opcao);

                try
                {
                    if (opcao == 1)
                    {
                        Produto produto = new Produto();

                        Console.Write("Nome: ");
                        produto.Nome = Console.ReadLine();

                        Console.Write("Quantidade em estoque: ");
                        produto.Quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Preço unitário: R$ ");
                        produto.Preco = double.Parse(Console.ReadLine());

                        using (StreamWriter escritor = File.AppendText(arquivo))
                        {
                            escritor.WriteLine(
                                produto.Nome + "," +
                                produto.Quantidade + "," +
                                produto.Preco.ToString("F2").Replace(",", "."));
                        }
                        Console.WriteLine("Produto cadastrado com sucesso!");
                    }
                    else if (opcao == 2)
                    {
                        using (StreamReader leitor = new StreamReader(arquivo))
                        {
                            if (leitor.EndOfStream)
                            {
                                Console.WriteLine("Nenhum produto cadastrado.");
                            }
                            else
                            {
                                while (!leitor.EndOfStream)
                                {
                                    string linha = leitor.ReadLine();
                                    string[] dados = linha.Split(',');

                                    if (dados.Length == 3)
                                    {
                                        Produto produto = new Produto();

                                        produto.Nome = dados[0];
                                        produto.Quantidade = int.Parse(dados[1]);
                                        produto.Preco = double.Parse(
                                            dados[2].Replace(".", ","));

                                        Console.WriteLine(
                                            "Produto: " + produto.Nome +
                                            " | Quantidade: " + produto.Quantidade +
                                            " | Preço: R$ " + produto.Preco.ToString("F2"));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Registro inválido!");
                                    }
                                }
                            }
                        }
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Programa encerrado!");
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida!");
                    }
                }
                catch
                {
                    Console.WriteLine("Erro ao acessar os dados do produto!");
                }
            }
        }
    }
}