using System;

namespace ExericiosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Você é: {EstadoAtual(idade)}");
            Console.ReadLine();
        }
        static string EstadoAtual(int idade)
        {
            if (idade >= 13 && idade < 19)
                return "Adolescente";
            else if (idade >= 19 && idade < 60)
                return "Adulto";
            else if (idade >= 60)
                return "Idoso";
            else
                return "Criança";
        }
    }
}
