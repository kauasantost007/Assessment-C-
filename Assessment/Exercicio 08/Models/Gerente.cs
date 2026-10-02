namespace Exercicio08.Models
{
    internal class Gerente : Funcionario
    {
        public decimal CalcularSalario()
        {
            return SalarioBase + (SalarioBase * 0.20m);
        }
    }
}