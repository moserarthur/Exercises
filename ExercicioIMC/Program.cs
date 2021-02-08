using System;

namespace ExercicioIMC
{
    /// <summary>
    /// Nome:Gustavo Rosauro
    /// Primeiro Exercicio
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua altura");//Solicita ao usuário
            string altura = Console.ReadLine();//Recebe o valor do usuário
            double alturaDouble = Convert.ToDouble(altura);//Trata o valor do usuário
            Console.WriteLine("Inforemee seu peso");
            string peso = Console.ReadLine();
            double pesoDouble = Convert.ToDouble(peso);
            //Chamando metodo que calcula o IMC passando os parametros seprando por ,
            //IMC foi alocado o valor de retorno na minha variavel imc
            Console.WriteLine($"Sua condição é : {SituacaoCorporal(CalculoIMC(pesoDouble,alturaDouble))}");//Agora mostro valor que está em minha variavel
            Console.ReadLine();
        }
        static double CalculoIMC(double peso, double altura)
        {
            double imc =  peso / Math.Pow(altura,2);//Retorna o calculo do imc
            return Math.Round(imc,2);
        }
        static string SituacaoCorporal(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do Peso";
            }
            else if (imc >= 18.5 && imc < 25)
            {
                return "Normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                return "Sobrepeso";
            }
            else
            {
                return "Obeso";
            }
        }
    }
}
