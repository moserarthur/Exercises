using ExemploContas.Model;
using System;
using System.Linq;

namespace ExemploContas
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new Conta().RetornaContas();
            Cliente c = new Cliente();
            c.Nome = "Gustavo Rosauro";
            c.Idade = 27;
            c.Conta = RetornaConta(contas,1);
            Console.WriteLine($"Nome: {c.Nome} Idade:{c.Idade} Saldo: {c.Conta.Saldo}");
            Console.ReadLine();
        }
        public static Conta RetornaConta(Conta[] contas,int numeroConta)
        {
            Conta conta = new Conta();
            foreach (var c in contas)
            {
                if (c.CodigoConta == numeroConta)
                {
                    return conta = c;
                }                
            }
            return conta;
        }
    }
}
