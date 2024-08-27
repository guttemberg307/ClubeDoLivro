namespace Clube_do_Livro
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public Livro Livro { get; set; } // Livro Livro mapea o modelo de dados apontando a classe a qual esta "herdado".
        public Usuario Dono { get; set; }
        public Usuario Solicitante { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
