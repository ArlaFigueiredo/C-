using System;

namespace RegistroContabil
{
    class Program
    {
        static void Main()
        {
            BalancoContabil balanco = new BalancoContabil();
            LivroLancamentoContabeis livro = new LivroLancamentoContabeis();
            RegistroContabil registroContabil = new RegistroContabil("Posto Kalilandia", "15.151.046/0001-89", balanco, livro);

            TipoConta tipoUm = Enum.Parse<TipoConta>("Ativo");
            TipoConta tipoDois = Enum.Parse<TipoConta>("Passivo");
            TipoConta tipoTres = Enum.Parse<TipoConta>("PatrimonioLiquido");

            Conta contaUm = new Conta("Banco", 100000, tipoUm);
            Conta contaDois = new Conta("Salario Funcionarios", 40000, tipoDois);
            Conta contaTres = new Conta("Lucros", 10000, tipoTres);

            balanco.AddConta(contaUm);
            balanco.AddConta(contaDois);
            balanco.AddConta(contaTres);

            Lancamentos lancamentoUm = new Lancamentos("Pagamento de Funcionarios", 30000, contaDois, contaUm);
            Lancamentos lancamentoDois = new Lancamentos("Integralizacao de Capital", 2000, contaTres, contaUm);

            livro.AddLancamento(lancamentoUm);
            livro.AddLancamento(lancamentoDois);

            Console.WriteLine(registroContabil.NomeEmpresa);
            Console.WriteLine(registroContabil.CGC);
            Console.WriteLine("BALANCO");
            Console.WriteLine(registroContabil.Balanco);
            Console.WriteLine("LIVRO DE LANÇAMENTOS");
            Console.WriteLine(registroContabil.Livro);

        }
    }
}
