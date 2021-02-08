using System;
using System.Collections.Generic;
using System.Text;

namespace PoliMorfismo.Model
{
    public class Carro:Veiculo
    {
        public Carro(string nome)
            :base(nome)//Retorna o valor para o construtor da sua classe principal
        { }
        public override void AcelerandoVeiculo()
        {
            Console.WriteLine("Acelerando meu carro.......");
        }
        public override void ParandoVeiculo()
        {
            Console.WriteLine("Estou parando meu carro......");
        }
    }
}
