using System.Globalization;

namespace RegistroContabil
{
    class Conta
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public TipoConta Tipo { get; set; }

        public Conta(string nome, double saldo, TipoConta tipo)
        {
            Nome = nome;
            Saldo = saldo;
            Tipo = tipo;
        }
        public override string ToString()
        {
            return Nome
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
