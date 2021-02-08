using System;
using TratamentoExcecoes.Exceptions;
namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
 
                Console.WriteLine("Informe um valor numerico");
                int valor = Convert.ToInt32(Console.ReadLine());
                if (valor.ToString().Length >= 3)
                {
                    //throw significa que será lançada uma excessão
                    throw new ApexExceptions("O valor informado estava com 3 digitos");
                }
        }
    }
}
