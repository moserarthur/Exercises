using ExercicioExceptions.Excpetions;
using System;

namespace ExercicioExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Informe um número");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 10)
                    throw new ValorMuitoBaixoException();
                else if (numero > 10000)
                    throw new ValorMuitoAltoException();
                for (int i = 0; i <= numero; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
