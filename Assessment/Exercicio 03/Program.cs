namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            double numero1, numero2;

            // Recebe a opção e os dois números
            escolha = EscolherOpcao();
            numero1 = LerOperando("Digite o primeiro número: ");
            numero2 = LerOperando("Digite o segundo número: ");

            // Realiza o cálculo escolhido
            Calcular(escolha, numero1, numero2);
        }
        // Exibe as opções da calculadora
        public static void ExibirMenu()
        {
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("[1] - Soma");
            Console.WriteLine("[2] - Subtração");
            Console.WriteLine("[3] - Multiplicação");
            Console.WriteLine("[4] - Divisão");
        }
        // Valida a opção escolhida pelo usuário
        public static int EscolherOpcao()
        {
            int escolha;

            do
            {
                ExibirMenu();
                escolha = LerInteiro("Escolha uma opção: ");

                if ((escolha < 1) || (escolha > 4))
                {
                    Console.WriteLine("Erro: opção inválida");
                }
                else
                {
                    break;
                }
            } while (true);

            return escolha;
        }
        // Lê e valida um número inteiro
        public static int LerInteiro(string mensagem)
        {
            int numero;

            do
            {
                Console.Write(mensagem);

                try
                {
                    numero = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: valor inválido");
                }

            } while (true);

            return numero;
        }
        // Lê e valida os números da operação
        public static double LerOperando(string mensagem)
        {
            double numero;

            do
            {
                Console.Write(mensagem);

                try
                {
                    numero = double.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: valor inválido");
                }
            } while (true);

            return numero;
        }
        // Escolhe qual operação será executada
        public static void Calcular(int escolha, double numero1, double numero2)
        {
            switch (escolha)
            {
                case 1:
                    Somar(numero1, numero2);
                    break;

                case 2:
                    Subtrair(numero1, numero2);
                    break;

                case 3:
                    Multiplicar(numero1, numero2);
                    break;

                case 4:
                    Dividir(numero1, numero2);
                    break;

                default:
                    Console.WriteLine("Erro: opção inválida");
                    break;
            }
        }
        public static void Somar(double numero1, double numero2)
        {
            double resultado;

            resultado = numero1 + numero2;
            Console.WriteLine("Soma = " + resultado);
        }
        public static void Subtrair(double numero1, double numero2)
        {
            double resultado;

            resultado = numero1 - numero2;
            Console.WriteLine("Subtração = " + resultado);
        }
        public static void Multiplicar(double numero1, double numero2)
        {
            double resultado;

            resultado = numero1 * numero2;
            Console.WriteLine("Multiplicação = " + resultado);
        }
        // Faz a divisão e impede divisão por zero
        public static void Dividir(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                Console.WriteLine("Erro: não é possível dividir por zero");
                return;
            }
            double resultado = numero1 / numero2;

            Console.WriteLine("Divisão = " + resultado);
        }
    }
}