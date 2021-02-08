using System;

namespace Laços
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            decimal precoInicial = 5.0m;
            decimal despesas = 200m;
            int quantidadeInicial = 120;

            decimal lucroMaximo = 0m;

            while (precoInicial > 0)
            {
                decimal lucro = Lucro(precoInicial, quantidadeInicial, despesas);
                if (lucro > lucroMaximo)
                {
                    lucroMaximo = lucro;
                }
                else
                {
                    Console.WriteLine("O valor do ingresso para o lucro maximo é {0}",precoInicial);
                }
                precoInicial -= 0.5m;
                quantidadeInicial += 26;
            }
        }
        static decimal Lucro(decimal preco, int quantidade, decimal despesas)
        {
            return preco * quantidade - despesas;
        }
    }
}
