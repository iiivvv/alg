using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Введите размер матрицы");
            int n = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Введите матрицу");
            int[,] matr = new int[n, n + 1];
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                string s = Console.ReadLine();
                string[] arr = s.Split(' ');
                for (int j = 0; j < n; j++)
                {

                    matr[i, j] = int.Parse(arr[j]);
                    //Console.WriteLine(matr[i, j]);
                    k += matr[i, j];
                }
                matr[i, n] = k;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(matr[i, n] + ": ");
                for (int j = 0; j < n; j++)
                {
                    if (matr[i, j] != 0)
                        Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

