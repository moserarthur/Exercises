using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Model
{
    public class Pato:Animal
    {
        public Pato(string nome)
        {
            CadastrarAnimal(nome);
        }
        public override void CadastrarAnimal(string nome)
        {
            base.CadastrarAnimal(nome);
        }
        public override void EmitirSom()
        {
            Console.WriteLine("Quack Quack Quack");
        }
    }
}
