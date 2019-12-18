using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Molecula
{
    class Molecula
    {
        List<Elementos> Atomos = new List<Elementos>();

        public Molecula()
        {
            List<Elementos> Atomos = new List<Elementos>();
        }

        public void InsereAtomo(Elementos elemento)
        {
            /*Elementos[] ProximoAtomo = new Elementos[this.Atomos.Length + 1];

              for (int i=0; i < this.Atomos.Length; i++)
              ProximoAtomo[i] = this.Atomos[i];

              ProximoAtomo[ProximoAtomo.Length - 1] = elemento;
              ProximoAtomo = this.Atomos;*/

            Atomos.Add(elemento); 
        }

        public string Menor()
        {
            int menor = 100000;
            string simbolo = "";
            foreach (Elementos atomo in Atomos)
                    if (atomo.NumeroAtomico < menor)
                {
                    menor =atomo.NumeroAtomico;
                    simbolo = atomo.Simbolo;
                }
            return simbolo;
        }

        public int QtdAtomos(Elementos elemento)
        {
            int qtd = 0;
            foreach (Elementos atomo in Atomos)
                if (atomo == elemento){
                    qtd++;
                }
            return qtd;
        }

        public bool ComposicaoIgual(Molecula Outramolecula)
        {
            foreach (Elementos atomo in Atomos)
            {
                if (outraMolecula.Contains(atomo))
                {

                }
            }
        }
    }
}
