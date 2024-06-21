namespace Biblioteca
{
    public abstract class MembroBiblioteca
    {
        public string Nome { get; set; }

        private int Id {  get; set; }

        internal abstract string EmprestarLivro();

        protected abstract void MaisInfos();
    }
}
