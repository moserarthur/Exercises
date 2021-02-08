using System;
using System.Collections.Generic;
using System.Text;

namespace PoliMorfismo.Model
{
    public abstract class Veiculo//Quando utilizamos a classe pai declaramos ela como abstrata ou abstract
    {
        public Veiculo(string nome)
        {
            this.Nome = nome;
        }
        public string Nome { get; set; }
        public virtual void AcelerandoVeiculo()
        { }
        public virtual void ParandoVeiculo()
        { }
    }
}
