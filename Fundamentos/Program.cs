using System;

namespace Fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console contem todosos atributos da nossa aplicação console
            //Exemplo escrever no consle e ler no console
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        static void ChamaMain()
        {
            RetornaSoma(4,5);
        }
        static double RetornaSoma(int a, int b)
        {
            return a + b;
        }
    }
}
