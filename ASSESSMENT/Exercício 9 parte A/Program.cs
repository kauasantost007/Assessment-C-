
using System;
using System.Globalization;

class Exercício9
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

        string[] nomes = new string[5];
        int[] quantidades = new int[5];
        decimal[] precos = new decimal[5];
        int total = 0;
        int opcao = 0;

        Console.WriteLine("=== CONTROLE DE ESTOQUE ===");

        while (opcao != 3)
        {
            Console.WriteLine("\n1 - Inserir Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida!");
                continue;
            }
            if (opcao == 1)
            {
                if (total == 5)
                {
                    Console.WriteLine("Limite de produtos atingido!");
                }
                else
                {
                    Console.Write("Nome do produto: ");
                    string nome = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(nome))
                    {
                        Console.Write("Digite um nome válido: ");
                        nome = Console.ReadLine();
                    }
                    int quantidade;
                    Console.Write("Quantidade em estoque: ");

                    while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0)
                    {
                        Console.Write("Quantidade inválida! Digite novamente: ");
                    }
                    decimal preco;
                    Console.Write("Preço unitário: R$ ");

                    while (!decimal.TryParse(Console.ReadLine(), out preco) || preco < 0)
                    {
                        Console.Write("Preço inválido! Digite novamente: R$ ");
                    }

                    nomes[total] = nome;
                    quantidades[total] = quantidade;
                    precos[total] = preco;

                    total++;

                    Console.WriteLine("Produto cadastrado com sucesso!");
                }
            }
            else if (opcao == 2)
            {
                Console.WriteLine("\n=== PRODUTOS CADASTRADOS ===");

                if (total == 0)
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                }
                else
                {
                    for (int i = 0; i < total; i++)
                    {
                        Console.WriteLine("Produto: " + nomes[i] +
                            " | Quantidade: " + quantidades[i] +
                            " | Preço: R$ " + precos[i].ToString("F2"));
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
