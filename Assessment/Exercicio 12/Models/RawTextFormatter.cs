namespace Exercicio12.Models
{
    internal class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contato> contatos)
        {
            foreach (Contato contato in contatos)
            {
                Console.WriteLine("Nome: " + contato.Nome +
                    " | Telefone: " + contato.Telefone +
                    " | Email: " + contato.Email);
            }
        }
    }
}