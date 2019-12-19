using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroContabil
{
    class RegistroContabil
    {
        private string NomeEmpresa { get; set; }
        private string CGC { get; set; }
        public BalancoContabil Balanco { get; set; }
        public LivroLancamentoContabeis Livro { get; set; }

        public RegistroContabil()
        {
        }

        public RegistroContabil(string nomeEmpresa, string cGC, BalancoContabil balanco, LivroLancamentoContabeis livro)
        {
            NomeEmpresa = nomeEmpresa;
            CGC = cGC;
            Balanco = balanco;
            Livro = livro;
        }
    }
}
