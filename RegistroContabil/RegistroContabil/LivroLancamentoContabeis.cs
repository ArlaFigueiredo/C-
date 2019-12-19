using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroContabil
{
    class LivroLancamentoContabeis
    {
        public List<Lancamentos> Lancamentos { get; set; } = new List<Lancamentos>();

        public LivroLancamentoContabeis()
        {
        }

        public void AddLancamento( Lancamentos lancamento)
        {
            Lancamentos.Add(lancamento);
        }
    }
}
