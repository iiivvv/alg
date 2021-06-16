using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tree
    {
        // Данные дерева
        public class TreeNode
        {
            public int value; // значение узла
            public TreeNode left; // левая ветвь
            public TreeNode right; // правая ветвь
        }
        public TreeNode node; // экземпляр класса данных

        //(1) Добавление элемента 
        public void AddElem(ref TreeNode node, int element)
        {
            //Если значения в узле нет вписываю его в узел
            if (node == null)
            {
                node = new TreeNode();
                node.value = element;
                //Console.WriteLine("Елемен добавлен");
            }
            //Если значение уже есть увеличиваю счетчик
            else if (element == node.value)
            {
                Console.WriteLine("Елемен уже существует");
            }
            //Если значение меньше того которое в узле иду в левую ветвь
            if (element < node.value)
            {
                AddElem(ref node.left, element);
            }
            //Если значение больше того которое в узле иду в правую ветвь
            else if (element > node.value)
            {
                AddElem(ref node.right, element);
            }
        }

        //(2) Удавение элемента
        public void DelElem(TreeNode node, int element)
        {
            //Если одна из ветвей равна удаляемому узлу и после его нет ничего
            if (node.left != null)
            {
                if (node.left.value == element & node.left.left == null & node.left.right == null)
                {
                    node.left = null;
                    goto exit;
                }
            }
            if (node.right != null)
            {
                if (node.right.value == element & node.right.left == null & node.right.right == null)
                {
                    node.right = null;
                    goto exit;
                }
            }

            if (element < node.value) //Иду к левому элементу
                DelElem(node.left, element);
            else if (element > node.value) //Иду к правому элементу
                DelElem(node.right, element);
            else if (element == node.value)//если нашел значение
            {
                if (node.right != null)//Заменяю правой нодой
                {
                    node.value = node.right.value;
                    DelElem(node, node.right.value);
                }
                else if (node.left != null)//Заменяю левой нодой
                {
                    node.value = node.left.value;
                    DelElem(node, node.left.value);
                }
            }
        exit:
            Console.Write("");
        }

        //(3) Поиск элемента (Прямой обход)
        public TreeNode Search(TreeNode node, int element)
        {
            if (node == null)
            {
                Console.WriteLine("Данного элемента нет в дереве");
                return null;
            }
            else if (element == node.value)
            {
                Console.WriteLine("В дереве присутствует элемент {0}", element);
                return node;
            }
            else if (element < node.value)
            {
                return Search(node.left, element);
            }
            else
            {
                return Search(node.right, element);
            }
        }

        //(4) Вывод дерева на экран
        public void PrintTree(TreeNode node, char ch, int n)
        {
            Console.WriteLine(new string(ch, n * 2) + "{0}", node.value);
            if (node.left != null)
                PrintTree(node.left, '=', n + 1);
            if (node.right != null)
                PrintTree(node.right, '-', n + 1);
        }
    }
}
