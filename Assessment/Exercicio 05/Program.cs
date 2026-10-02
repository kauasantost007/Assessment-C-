namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a data atual (DD/MM/AAAA): ");

            string textoData = Console.ReadLine();
            DateTime dataInformada = DateTime.Parse(textoData);

            DateTime dataFormatura = new DateTime(2028, 12, 16);

            if (dataInformada > DateTime.Now.Date)
            {
                Console.WriteLine("Erro: A data informada não pode ser no futuro!");
                return;
            }
            if (dataInformada >= dataFormatura)
            {
                Console.WriteLine("Parabéns! Você já deveria estar formado!");
                return;
            }
            int anosRestantes = dataFormatura.Year - dataInformada.Year;
            int mesesRestantes = dataFormatura.Month - dataInformada.Month;
            int diasRestantes = dataFormatura.Day - dataInformada.Day;

            if (diasRestantes < 0)
            {
                mesesRestantes = mesesRestantes - 1;

                DateTime mesAnterior = dataFormatura.AddMonths(-1);

                int quantidadeDias = DateTime.DaysInMonth(
                    mesAnterior.Year,
                    mesAnterior.Month
                );
                diasRestantes = diasRestantes + quantidadeDias;
            }
            if (mesesRestantes < 0)
            {
                anosRestantes = anosRestantes - 1;
                mesesRestantes = mesesRestantes + 12;
            }
            Console.WriteLine("Faltam " + anosRestantes + " ano(s), " +
                mesesRestantes + " mês(es) e " +
                diasRestantes + " dia(s) para sua formatura!");

            if (anosRestantes == 0 && mesesRestantes < 6)
            {
                Console.WriteLine("Esta chegando! Prepare-se para a formatura!");
            }
        }
    }
}