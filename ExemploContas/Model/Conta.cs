using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploContas.Model
{
    public class Conta
    {
        public int CodigoConta { get; set; }
        public string Saldo { get; set; }
        public Conta[] RetornaContas()
        {
            Conta[] contas = new Conta[2];
            contas[0] = new Conta() { CodigoConta = 1, Saldo = "DEZ MIL" };
            contas[1] = new Conta() { CodigoConta = 2, Saldo = "VINTE MIL" };
            return contas;
        }
    }
}
