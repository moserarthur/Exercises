using System;

namespace TiposDados
{
    /// <summary>
    /// Nome: Gustavo Rosauro
    /// Aula: Tipos de Dados
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "array";//array de characteres començando na posição 0
            char t = 't';//aceita somente um character
            int idade = 27;// valores inteiros sendo numero reais
            bool vontadeEstudar = true;//seria o tipo primativo 1 ou 0 
            //verdadeiro ou false
            texto = "novo testo";//posso alterar pois não é uma constante
            const string textoFixo = "não posso alterar";// constante o valor
            //é constante ao longo do meu codigo
            ////////////////////////Operadores///////////////////////////
            int a, b;
            a = 10;
            b = 30;
            int soma = a + b;
            Console.WriteLine(soma);
            Console.ReadLine();
            int c, d;
            c = 20;
            d = 2;
            int resto = 21 % 2;//Utilizado para retornar sobra da divisão
            Console.WriteLine($"Resto da divisão {resto}");
            Console.Read();
        }
    }
}
