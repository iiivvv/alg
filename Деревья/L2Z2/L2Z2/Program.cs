using System;

namespace L2Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            AVL tree = new AVL();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(2);
            tree.Delete(7);
            tree.PrintTree();

            Console.ReadKey();
        }

    }
}
