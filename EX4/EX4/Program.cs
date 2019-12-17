using System;

namespace EX4
{
    class Program
    {
        static void Main()
        {
            string camada;

            ElementoQuimico elemento = new ElementoQuimico(11, 23, "Sodio");
            ElementoQuimico outroElemento = new ElementoQuimico(6, 12, "Carbono");

            Console.WriteLine("Numero Atomico (Z) " + elemento.getNome() + ": " + elemento.getNumeroAtomico());

            if (elemento.Compara(outroElemento) )
                Console.WriteLine("Os elementos sao iguais");
            else
                Console.WriteLine("Os elementos sao diferentes");

            elemento.Distribuicao();

            Console.WriteLine("Informe a Camada que deseja saber o num. de eletrons: ");
            camada = Console.ReadLine();
            Console.WriteLine("O num. de eletrons presente na camada eh: " + elemento.EletronsCamada(camada));

            Console.WriteLine("PROTONS: " + elemento.Protons());
            Console.WriteLine("NEUTRONS: " + elemento.Neutrons());
            Console.WriteLine("ELETRONS: " + elemento.Eletrons());

            Console.WriteLine("DISTRIBUIÇÃO ELETRONICA: " + elemento.Distribuicao());

            Console.WriteLine("VALENCIA: " + elemento.Valencia());




        }
    }
}
