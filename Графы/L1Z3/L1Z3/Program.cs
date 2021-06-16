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
            Console.WriteLine("Введите число n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите в строчку через пробел с какими вершинами связанна данная точка");
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s = Console.ReadLine();
                string[] arr = s.Split(':', ' ');
                for (int j = 1; j < arr.Length; j++)
                {
                    Console.WriteLine("(" + arr[0] + ", " + arr[j] + ")");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
