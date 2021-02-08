using System;

namespace Telefone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu número de telefone:");
            string telefone = Console.ReadLine();
            if (telefone.Length > 6 && telefone.Length < 12 && SomenteNumeros(telefone))
            {
                switch (telefone.Length)
                {
                    case 7:
                        Console.WriteLine("Telefone é {0}-{1}", telefone.Substring(0, 3), telefone.Substring(3));
                        break;
                    case 8:
                        Console.WriteLine("Telefone é {0}-{1}", telefone.Substring(0, 4), telefone.Substring(4));
                        break;
                    case 9:
                        if (telefone.Substring(0, 1) == "9")
                        {
                            Console.WriteLine("Telefone é{0}{1}", telefone.Substring(0, 5), telefone.Substring(5));
                        }
                        else
                        {
                            Console.WriteLine("Telefone é ({0}){1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 3), telefone.Substring(5));
                        }
                        break;
                    case 10:
                        Console.WriteLine("Telefone é ({0}){1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 4), telefone.Substring(6));
                        break;
                    case 11: Console.WriteLine("Telefone é ({0}){1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 5), telefone.Substring(7));
                        break;
                }
            }
            else
            {
                Console.WriteLine("Números inválidos, informe um telefone válido");

            }
        }

        static bool SomenteNumeros(string numeros)
        {
            long resultado;
            return Int64.TryParse(numeros, out resultado);

        }
    }
}
