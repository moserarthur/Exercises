using System;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaNomes = new List<string> {"Gustavo","Pedro" };//Lista Strings
            listaNomes.Add("José");
            listaNomes.Add("Maria");
            listaNomes.Add("Augusto");
            listaNomes.RemoveAt(4);
            for (int i = 0; i < listaNomes.Count; i++)
            {
                Console.WriteLine(listaNomes[i]);
            }
            Console.ReadLine();
            string[] arrayNomes = new string[5] { "Gustavo", "Pedro","José","Maria","Augusto"};//Array strings
            for (int i = 0; i < arrayNomes.Length; i++)
            {
                Console.WriteLine(arrayNomes[i]);
            }
            Console.ReadLine();
            
        }
    }
}
