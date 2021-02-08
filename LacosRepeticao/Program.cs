using System;

namespace LacosRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutaRepeticoes();
        }
        static void ExecutaRepeticoes()
        {
            for (int i = 5; i >= 0; i--)//Primeira quantiadade de repetições
            {
                string x = "";
                for (int j = 0; j < i; j++)//Concatena x quantidade de repetições
                {
                    x += "x";
                }
                Console.WriteLine(x);//Mostra o x com o valor concatenado
            }
            Console.ReadLine();
        }
    }
}
