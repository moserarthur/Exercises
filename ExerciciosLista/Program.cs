using System;
using System.Collections.Generic;

namespace ExerciciosLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaInteiros = new List<int>();
            int[] arrayInteiros = new int[5]//Exemplo arrayInteiros[0] = 4
                {
                    4,//posicao = 0
                    5,//posicao = 1
                    8,//posicao = 2
                    9,//posicao = 3
                    110//posicao = 4
                };
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                listaInteiros.Add(arrayInteiros[i] * 10);//litstaInteiros[0] = 4 * 10 = 40
            }
            for (int i = 0; i < listaInteiros.Count; i++)
            {
                Console.WriteLine($"{arrayInteiros[i]} x 10 = {listaInteiros[i]}"); // 4 x 10 = 40
            }
            Console.ReadLine();
        }
    }
}
