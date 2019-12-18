using System;

namespace Molecula
{
    class Program
    {
        static void Main()
        {
            Elementos carbono = new Elementos("C", 12);
            Elementos oxigenio = new Elementos("O", 16);

            Molecula co = new Molecula();
            Molecula co2 = new Molecula();

            co.InsereAtomo(carbono);
            co.InsereAtomo(oxigenio);

            co2.InsereAtomo(carbono);
            co2.InsereAtomo(oxigenio);
            co2.InsereAtomo(oxigenio);

            Console.WriteLine("O atomo que tem o menor numero atomico da molecula de CO eh: " + co.Menor());
            Console.WriteLine("A quantidade de atomos de oxigenio na molecula de CO2 eh: " + co2.QtdAtomos(oxigenio));
            Console.WriteLine(": " + co.ComposicaoIgual(co2));
        }
    }
}
