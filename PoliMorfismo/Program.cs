using PoliMorfismo.Model;
using System;

namespace PoliMorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculo = new Veiculo[2];
            veiculo[0] = new Carro("Ferrari");
            veiculo[1] = new Barco("Phantom");
            for (int i = 0; i < veiculo.Length; i++)
            {
                AcelerandoVeiculo(veiculo[i]);
                Console.WriteLine("Aperte Enter para parar o veiculo");
                Console.ReadLine();
                ParandoVeiculo(veiculo[i]);
            }
        }
        static void AcelerandoVeiculo(Veiculo v)
        {
            Console.WriteLine(v.Nome);
            v.AcelerandoVeiculo();
        }
        static void ParandoVeiculo(Veiculo v)
        {
            Console.WriteLine(v.Nome);
            v.ParandoVeiculo();
        }
    }
}
