namespace Biblioteca
{
    public abstract class MembroBiblioteca
    {
        public string Nome { get; set; }

        private string Id {  get; set; }

        internal abstract string EmprestarLivro();

        public abstract string DetalharInformacoes();
    } 
}
