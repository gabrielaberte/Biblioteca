namespace Biblioteca
{
    public abstract class Administrador
    {
        private string Id { get; set; }

        internal abstract void GerenciarBiblioteca();

        protected abstract void MaisInfo();
    }
}
