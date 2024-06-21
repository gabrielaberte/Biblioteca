namespace Biblioteca
{
    public abstract class Funcionario
    {
        protected internal string Id { get; set; }

        protected abstract void AddLivro();

        private protected abstract void RemoverLivro();

        public abstract void AddNovoFuncionario();
    }
}
