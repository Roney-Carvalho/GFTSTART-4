namespace Desafio3.Entities
{
    public class Leitor
    {
        public string Nome { get; set; } = string.Empty;
        public Livro LivroFavorito { get; set; }
        public List<Livro> MyProperty { get; set; }


        public void AdicionarLivro(Livro livro)
        {
            
        }

        public void RemoverLivro(Livro livro)
        {
            
        }

    }
}