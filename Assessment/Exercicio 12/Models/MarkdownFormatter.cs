namespace Exercicio12.Models
{
    internal class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            Console.WriteLine("\n## Lista de Contatos");

            foreach (Contato contato in contatos)
            {
                Console.WriteLine("- **Nome:** " + contato.Nome);
                Console.WriteLine("- Telefone: " + contato.Telefone);
                Console.WriteLine("- Email: " + contato.Email);
            }
        }
    }
}