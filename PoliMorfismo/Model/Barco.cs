using System;
using System.Collections.Generic;
using System.Text;

namespace PoliMorfismo.Model
{
    public class Barco:Veiculo
    {
        public Barco(string nome)
            :base(nome)
        { }
        public override void AcelerandoVeiculo()
        {
            Console.WriteLine("Estou acelerando meu barco.....");
        }
        public override void ParandoVeiculo()
        {
            Console.WriteLine("Estou parando meu barco........");
        }
    }
}
