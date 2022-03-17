namespace Desafio3.Entities
{
    public class Livro
    {
        public string Titulo { get; set; } = string.Empty;
        public int QtdPaginas { get; set; }
        public int PaginasLidas { get; set; }

        public double VerificarProgresso()
        {

            return 0.0;
        }

        public int AdicionarPaginasLidas()
        {
            return 0;
        }
    }
}