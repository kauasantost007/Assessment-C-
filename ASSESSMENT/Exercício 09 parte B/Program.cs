
using System;
using System.IO;
using System.Globalization;

class Exercício9
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

        string arquivo = "estoque.txt";
        int opcao = 0;

        try
        {
            if (!File.Exists(arquivo))
            {
                using (StreamWriter escritor = File.CreateText(arquivo))
                {
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Erro ao criar o arquivo!");
            return;
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Sem permissão para criar o arquivo!");
            return;
        }

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
                try
                {
                    int total = 0;

                    using (StreamReader leitor = new StreamReader(arquivo))
                    {
                        while (leitor.ReadLine() != null)
                        {
                            total++;
                        }
                    }

                    if (total >= 5)
                    {
                        Console.WriteLine("Limite de produtos atingido!");
                    }
                    else
                    {
                        Console.Write("Nome do produto: ");
                        string nome = Console.ReadLine();

                        while (string.IsNullOrWhiteSpace(nome) || nome.Contains(","))
                        {
                            Console.Write("Digite um nome válido, sem vírgulas: ");
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

                        using (StreamWriter escritor = File.AppendText(arquivo))
                        {
                            escritor.WriteLine(nome + "," +
                                quantidade + "," +
                                preco.ToString("F2", CultureInfo.InvariantCulture));
                        }

                        Console.WriteLine("Produto cadastrado com sucesso!");
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("Erro ao acessar o arquivo!");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Sem permissão para acessar o arquivo!");
                }
            }
            else if (opcao == 2)
            {
                Console.WriteLine("\n=== PRODUTOS CADASTRADOS ===");

                try
                {
                    bool encontrouProduto = false;

                    using (StreamReader leitor = new StreamReader(arquivo))
                    {
                        string linha;

                        while ((linha = leitor.ReadLine()) != null)
                        {
                            string[] dados = linha.Split(',');

                            if (dados.Length != 3)
                            {
                                Console.WriteLine("Produto com formato inválido!");
                                continue;
                            }

                            int quantidade;
                            decimal preco;

                            if (string.IsNullOrWhiteSpace(dados[0]) ||
                                !int.TryParse(dados[1], out quantidade) ||
                                quantidade < 0 ||
                                !decimal.TryParse(dados[2], NumberStyles.Number,
                                    CultureInfo.InvariantCulture, out preco) ||
                                preco < 0)
                            {
                                Console.WriteLine("Produto com dados inválidos!");
                                continue;
                            }

                            Console.WriteLine("Produto: " + dados[0] +
                                " | Quantidade: " + quantidade +
                                " | Preço: R$ " + preco.ToString("F2"));

                            encontrouProduto = true;
                        }
                    }

                    if (!encontrouProduto)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                }
                catch (IOException)
                {
                    Console.WriteLine("Erro ao ler o arquivo!");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("Sem permissão para ler o arquivo!");
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
