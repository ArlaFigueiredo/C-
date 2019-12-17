using System;
using System.Collections.Generic;
using System.Text;

namespace EX4
{
    class ElementoQuimico
    {
        private int NumeroAtomico { get; set; }
        private int NumeroMassa { get; set; }
        private string Nome { get; set; }
        private CamadaEletronica CamadaEletrons= new CamadaEletronica(0,0,0,0,0,0,0);


        public ElementoQuimico(int numeroAtomico, int numeroMassa, string nome)

        {
            this.setNumeroAtomico(numeroAtomico);
            this.setNumeroMassa(numeroMassa);
            this.setNome(nome);
        }

        public void setNumeroAtomico(int numeroAtomico)
        {
            this.NumeroAtomico = numeroAtomico;
        }

        public int getNumeroAtomico()
        {
            return this.NumeroAtomico;
        }

        public void setNumeroMassa(int numeroMassa)
        {
            this.NumeroMassa = numeroMassa;
        }

        public int getNumeroMassa()
        {
            return this.NumeroMassa;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public bool Compara(ElementoQuimico outroElemento)
        {
            return (this.getNumeroAtomico() == outroElemento.NumeroAtomico);
                
        }

        public int Protons()
        {
            return this.getNumeroAtomico();
        }

        public int Eletrons()
        {
            return this.getNumeroAtomico();
        }

        public int Neutrons()
        {
            return this.getNumeroMassa() - this.getNumeroAtomico();
        }

        public string Distribuicao()
        {
            if (this.getNumeroAtomico() <= 2)
            {
                CamadaEletrons.K = this.getNumeroAtomico();
                return "K";
            }
            else if (this.getNumeroAtomico() > 2 && this.getNumeroAtomico() <= 10)
            {
                CamadaEletrons.K = 2;
                CamadaEletrons.L = this.getNumeroAtomico() - 2;
                return "K L";
            }
            else if (this.getNumeroAtomico() > 10 && this.getNumeroAtomico() <= 28)
            {
                CamadaEletrons.K = 2;
                CamadaEletrons.L = 8;
                CamadaEletrons.M = this.getNumeroAtomico() - 10;
                return "K L M";
            }
            else if (this.getNumeroAtomico() > 28 && this.getNumeroAtomico() <= 60)
            {
                CamadaEletrons.K = 2;
                CamadaEletrons.L = 8;
                CamadaEletrons.M = 18;
                CamadaEletrons.N = this.getNumeroAtomico() - 28;
                return "K L M N";
            }
            else if (this.getNumeroAtomico() > 60 && this.getNumeroAtomico() <= 92)
            {
                CamadaEletrons.K = 2;
                CamadaEletrons.L = 8;
                CamadaEletrons.M = 18;
                CamadaEletrons.N = 32;
                CamadaEletrons.O = this.getNumeroAtomico() - 60;
                return "K L M N O";
            }
            else if (this.getNumeroAtomico() > 92 && this.getNumeroAtomico() <= 110)
            {
                CamadaEletrons.K = 2;
                CamadaEletrons.L = 8;
                CamadaEletrons.M = 18;
                CamadaEletrons.N = 32;
                CamadaEletrons.O = 32;
                CamadaEletrons.P = this.getNumeroAtomico() - 92;
                return "K L M N O P";
            }
            else if (this.getNumeroAtomico() > 110)
            {
                CamadaEletrons.K = 2;
                CamadaEletrons.L = 8;
                CamadaEletrons.M = 18;
                CamadaEletrons.N = 32;
                CamadaEletrons.O = 32;
                CamadaEletrons.P = 18;
                CamadaEletrons.Q = this.getNumeroAtomico() - 110;
                return "K L M N O P Q";
            }
            return "";
        }

        public int EletronsCamada(string camada)
        {
            if (camada == "K")
                return CamadaEletrons.K;
            else if (camada == "L")
                return CamadaEletrons.L;
            else if (camada == "M")
                return CamadaEletrons.M;
            else if (camada == "N")
                return CamadaEletrons.N;
            else if (camada == "O")
                return CamadaEletrons.O;
            else if (camada == "P")
                return CamadaEletrons.P;
            else if (camada == "Q")
                return CamadaEletrons.Q;
            return 0;
     
        }

        public string Valencia()
        {
            if (CamadaEletrons.Q != 0)
                return "Q";
            else if (CamadaEletrons.P != 0)
                return "P";
            else if (CamadaEletrons.O != 0)
                return "O";
            else if (CamadaEletrons.N != 0)
                return "N";
            else if (CamadaEletrons.M != 0)
                return "M";
            else if (CamadaEletrons.L != 0)
                return "L";
            else if (CamadaEletrons.K != 0)
                return "K";
            return "";
        }


    }
}
