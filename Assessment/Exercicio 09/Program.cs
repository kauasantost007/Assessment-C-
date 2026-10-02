using Exercicio09A.Models;

namespace Exercicio09A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto[] produtos = new Produto[5];

            int total = 0;
            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine("\n=== CONTROLE DE ESTOQUE ===");
                Console.WriteLine("[1] - Inserir Produto");
                Console.WriteLine("[2] - Listar Produtos");
                Console.WriteLine("[3] - Sair");
                Console.Write("Escolha uma opção: ");

                int.TryParse(Console.ReadLine(), out opcao);

                if (opcao == 1)
                {
                    if (total == 5)
                    {
                        Console.WriteLine("Limite de produtos atingido!");
                    }
                    else
                    {
                        Produto produto = new Produto();

                        Console.Write("Nome: ");
                        produto.Nome = Console.ReadLine();

                        Console.Write("Quantidade em estoque: ");
                        produto.Quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Preço unitário: R$ ");
                        produto.Preco = double.Parse(Console.ReadLine());

                        produtos[total] = produto;
                        total++;

                        Console.WriteLine("Produto cadastrado com sucesso!");
                    }
                }
                else if (opcao == 2)
                {
                    if (total == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    else
                    {
                        for (int i = 0; i < total; i++)
                        {
                            Console.WriteLine(
                                "Produto: " + produtos[i].Nome +
                                " | Quantidade: " + produtos[i].Quantidade +
                                " | Preço: R$ " + produtos[i].Preco.ToString("F2"));
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
        }
    }
}