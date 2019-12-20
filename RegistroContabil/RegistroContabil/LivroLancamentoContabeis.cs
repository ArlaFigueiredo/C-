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

        public override string ToString()
        {
            StringBuilder lv = new StringBuilder();
            foreach (Lancamentos lancamento in Lancamentos)
            {
                lv.AppendLine(lancamento.ToString());
            }
            return lv.ToString();
        }
    }
}
