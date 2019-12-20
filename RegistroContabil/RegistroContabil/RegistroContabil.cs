namespace RegistroContabil
{
    class RegistroContabil
    {
        public string NomeEmpresa { get; set; }
        public string CGC { get; set; }
        public BalancoContabil Balanco { get; set; }
        public LivroLancamentoContabeis Livro { get; set; }

        public RegistroContabil(string nomeEmpresa, string cGC, BalancoContabil balanco, LivroLancamentoContabeis livro)
        {
            NomeEmpresa = nomeEmpresa;
            CGC = cGC;
            Balanco = balanco;
            Livro = livro;
        }
    }
}
