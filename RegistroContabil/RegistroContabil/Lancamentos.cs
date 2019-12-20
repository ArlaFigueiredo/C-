using System.Globalization;

namespace RegistroContabil
{
    class Lancamentos
    {
        public string Descricao;
        public double Valor;
        public Conta ContaCredito;
        public Conta ContaDebito;

        public Lancamentos(string descricao, double valor, Conta contaCredito, Conta contaDebito)
        {
            Descricao = descricao;
            Valor = valor;
            ContaCredito = contaCredito;
            ContaDebito = contaDebito;
        }

        public void Creditar()
        {
            if(this.ContaCredito.Tipo == TipoConta.Ativo)
            {
                this.ContaCredito.Saldo -= Valor;
            }else if (this.ContaCredito.Tipo == TipoConta.Passivo || this.ContaCredito.Tipo == TipoConta.PatrimonioLiquido)
            {
                this.ContaCredito.Saldo += Valor;
            }
        }

        public void Debitar()
        {
            if (this.ContaCredito.Tipo == TipoConta.Ativo)
            {
                this.ContaCredito.Saldo += Valor;
            }
            else if (this.ContaCredito.Tipo == TipoConta.Passivo || this.ContaCredito.Tipo == TipoConta.PatrimonioLiquido)
            {
                this.ContaCredito.Saldo -= Valor;
            }

        }
        public override string ToString()
        {
            return "Descricao: "
                + Descricao
                + ", Valor: $"
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + ", Credito: "
                + ContaCredito.Nome
                + ", Debito: "
                + ContaDebito.Nome;
        }
    }
}
