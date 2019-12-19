using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroContabil
{
    class Lancamentos
    {
        private string Descricao;
        double Valor;

        public Lancamentos(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public void AddContaCredito()
        {

        }

        public void AddContaDebito()
        {

        }
    }
}
