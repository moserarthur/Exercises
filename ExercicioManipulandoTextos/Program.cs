using System;

namespace ExercicioManipulandoTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome completo");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Informe sua idade");
            double idade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe seu telefone com DDD");
            string telefone = Console.ReadLine();
            Console.WriteLine($"Telefone: {FormataTelefone(telefone)}");
            Console.WriteLine($"A raiz quadrada de sua idade é {RaizQuadrada(idade)}");
            Console.WriteLine($"Trocando espações por ';' " +
                $"fica assim: {nomeCompleto.Replace(" ",";")} ");
            Console.ReadLine();
        }
        static string FormataTelefone(string telefone)
        {
                string dd = telefone.Substring(0, 2);
                string cincoDigitos = telefone.Substring(2, 5);
                string quatroDigitos = telefone.Substring(7);
                return $"({dd}){cincoDigitos}-{quatroDigitos}";
        }
        static double RaizQuadrada(double idade) => Math.Round(Math.Sqrt(idade),2);

    }
}
