using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();//Экземпляр дерева
            int element;

        deistvie1:
            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(
                "\nВыберите действие:" +
                "\n1) Добавление элемента(ов)" +
                "\n2) Удаление элемента" +
                "\n3) Поиск элемента" +
                "\n4) Печать дерева");
        vibor1:
            string vibor1 = Console.ReadLine();
            Console.WriteLine(new string('-', 50));
            switch (vibor1)
            {
                case "1":
                    {
                        Console.WriteLine(
                            "\nВыберите действие:" +
                            "\n1) Вручную" +
                            "\n2) Автоматически");
                    vibor2:
                        string vibor2 = Console.ReadLine();
                        Console.WriteLine(new string('-', 50));
                        switch (vibor2)
                        {
                            case "1":
                                Console.Write("\nСколько вы хотите добавить элементов: ");
                                int kolvoEl = int.Parse(Console.ReadLine());
                                for (int i = 0; i < kolvoEl; i++)
                                {
                                    Console.Write("Введите {0} элемент: ", i + 1);
                                    element = int.Parse(Console.ReadLine());
                                    tree.AddElem(ref tree.node, element);
                                }
                                break;

                            case "2":
                                Console.Write("\nСколько вы хотите добавить элементов: ");
                                int kolvoEl2 = int.Parse(Console.ReadLine());
                                Console.Write("Введите границу минимального элемента: ");
                                int min = int.Parse(Console.ReadLine());
                                Console.Write("Введите границу максимального элемента: ");
                                int max = int.Parse(Console.ReadLine());
                                Random random = new Random();
                                for (int i = 0; i < kolvoEl2; i++)
                                {
                                    element = random.Next(min, max);
                                    Console.WriteLine("Добавлен элемент {0}", element);
                                    tree.AddElem(ref tree.node, element);
                                }
                                break;
                            default:
                                Console.WriteLine("Ошибка! Попытайтесь снова");
                                goto vibor2;
                        }
                    }
                    goto deistvie1;

                case "2":
                    {
                        Console.Write("\nВведите какой элемент нужно удалить: ");
                        element = int.Parse(Console.ReadLine());
                        tree.DelElem(tree.node, element);
                        Console.WriteLine("Элемент удален");
                    }
                    goto deistvie1;

                case "3":
                    {
                        Console.Write("\nВведите какой элемент нужно найти: ");
                        element = int.Parse(Console.ReadLine());
                        tree.Search(tree.node, element);
                    }
                    goto deistvie1;

                case "4":
                    {
                        tree.PrintTree(tree.node, ' ', 0);
                    }
                    goto deistvie1;

                default:
                    Console.WriteLine("\nОшибка! Попытайтесь снова");
                    goto vibor1;
            }
        }
    }
}
