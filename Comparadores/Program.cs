using System;

namespace Comparadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            bool condicao1  = a == b;//false
            bool condicao2  = a > b;//true
            bool condicao3  = a < b;//flase
            bool condicao4  = a <= b;//false
            bool condicao5  = a >= b;//true
            bool condicao6 = a != b;//true
            Console.WriteLine($" a == b {condicao1}" +//Estamos concatenando 
                              $" a >  b {condicao2}" +//Nossos testos de resposta
                              $" a <  b {condicao3}" +
                              $" a <= b {condicao4}" +
                              $" a >= b {condicao5}" +
                              $" a != b {condicao6}");
           Console.ReadLine();
            //atribuição 
            int c = 1;
            c += 5;//Mantem o valor da variável e realiza a operação antes do igual
            //'?' se 'executa quando atingir a condição'  ':' se não 'executa quando não atingir a condição'
            string ternario = c == 6 ? "Calculou correto" : "Calculou errado";
        }
    }
}
