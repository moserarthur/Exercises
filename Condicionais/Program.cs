kp;using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu telefone");
            string telefone = Console.ReadLine();
            if (telefone.Length == 11)//Condição executa o bloco abaixo 
            {
                Console.WriteLine("Telefone está correto");
            }
            else if (telefone.Length == 8)//Caso não atenda a primeira vai segunda
            {
                Console.WriteLine("Seu telefone é Residencial"); 
            }
            else//Caso contrario executa o else
            {
                Console.WriteLine("Seu telefone está incorreto");
            }
            switch (telefone.Length)//Isolo o valor da minha variável
            {
                case 11://Caso valor no switch seja 11
                    Console.WriteLine("Telefone está correto");
                    break;
                case 8: //Caso valor no switch seja 8
                    Console.WriteLine("Seu telefone é Residencial");
                    break;
                default: //Caso não atenda nenhum valor
                    Console.WriteLine("Seu telefone está incorreto");
                    break;
            }
        }
    }
}
