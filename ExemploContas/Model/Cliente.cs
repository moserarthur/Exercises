using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploContas.Model
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Conta Conta { get; set; }
    }
}
