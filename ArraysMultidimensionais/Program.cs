using System;

namespace ArraysMultidimensionais
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,,] arrayTriDimensional = new int[2, 2, 3] { {{ 1, 2, 3 }, { 1, 3, 4 } },{ {3,4,5 },{3,4,5} } };
            for (int i = 0; i < arrayTriDimensional.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTriDimensional.GetLength(1); j++)
                {
                    for (int g = 0; g < arrayTriDimensional.GetLength(2); g++)
                    {
                        Console.WriteLine($"Linha : {i} Coluna1: {j} Coluna2: {g}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
