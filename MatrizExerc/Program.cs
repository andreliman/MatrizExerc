using System;

namespace MatrizExerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de linhas e colunas para criação da matriz: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite os valores da linha {i + 1}:");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Main diagonal:");
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"Negative numbers: {count}");            
        }
    }
}
