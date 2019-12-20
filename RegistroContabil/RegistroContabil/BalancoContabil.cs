using System.Collections.Generic;
using System.Text;

namespace RegistroContabil
{
    class BalancoContabil
    {
        public List<Conta> Contas { get; set; } = new List<Conta>();

        public void AddConta(Conta conta)
        {
            Contas.Add(conta);
        }
        public override string ToString()
        {
            StringBuilder rg = new StringBuilder();
            foreach (Conta conta in Contas)
            {
                rg.AppendLine(conta.ToString());
            }
            return rg.ToString();
        }
    }
}
