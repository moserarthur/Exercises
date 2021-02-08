using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Model
{
    public abstract class Animal
    {
        public string Nome { get;private set; }
        public virtual void EmitirSom()
        { }
        public virtual void CadastrarAnimal(string nome)
        {
            this.Nome = nome;
        }
    }
}
