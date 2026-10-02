namespace Exercicio07.Models
{
    internal class ContaBancaria
    {
        public string Titular;
        private decimal Saldo = 0;

        // Adiciona dinheiro à conta
        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo = Saldo + valor;
                Console.WriteLine("Depósito de R$ " + valor.ToString("F2") + " realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
            }
        }
        // Realiza o saque se houver saldo suficiente
        public void Sacar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo = Saldo - valor;
                Console.WriteLine("Saque de R$ " + valor.ToString("F2") + " realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente pra realizar o saque!");
            }
        }
        // Mostra o saldo sem permitir a alteração direta
        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo atual: R$ " + Saldo.ToString("F2"));
        }
    }
}