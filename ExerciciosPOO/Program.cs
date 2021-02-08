using ExerciciosPOO.Model;
using System;

namespace ExerciciosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animais = new Animal[3];
            animais[0] = new Pato("Donald");
            animais[1] = new Gato("Garfiled");
            animais[2] = new Cachorro("Snoopy Dog");
            foreach(var animal in animais)
            {
                EmitirSom(animal);
                Console.WriteLine("Aperte Enter e veja o proximo animal");
                Console.ReadLine();
            }
        }
        static void EmitirSom(Animal a)
        {
            Console.WriteLine($"O nome do animal é {a.Nome}");
            a.EmitirSom();
        }
    }
}
