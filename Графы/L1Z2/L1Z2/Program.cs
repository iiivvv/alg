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
            Console.WriteLine("Введите 2 числа n и m через пробел");
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');
            int n = int.Parse(arr[0]);
            int m = int.Parse(arr[1]);
            int[,] matr = new int[n, n + 1];
            Console.WriteLine("Введите 2 числа u и v через пробел");

            for (int i = 0; i < m; i++)
            {
                str = Console.ReadLine();
                string[] arr2 = str.Split(' ');
                int x = int.Parse(arr2[0]);
                int y = int.Parse(arr2[1]);
                matr[x - 1, y - 1] = 1;
                matr[y - 1, x - 1] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                int k = 0;
                for (int j = 0; j < n; j++)
                {
                    //Console.Write(matr[i, j]+" ");
                    k += matr[i, j];
                }
                matr[i, n] = k;
                // Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(matr[i, n] + ": ");
                for (int j = 0; j < n; j++)
                {
                    if (matr[i, j] == 1)
                        Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
