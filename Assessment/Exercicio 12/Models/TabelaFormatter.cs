namespace Exercicio12.Models
{
    internal class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("| Nome | Telefone | Email |");
            Console.WriteLine("----------------------------------------");

            foreach (Contato contato in contatos)
            {
                Console.WriteLine("| " + contato.Nome +
                    " | " + contato.Telefone +
                    " | " + contato.Email + " |");
            }

            Console.WriteLine("----------------------------------------");
        }
    }
}