using System;
using System.Collections.Generic;

namespace ACID_LABA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "24wfwegfw1";
            var digit = new Dictionary<int, string>();
            digit.Add(StringHashCode20(str), str);
            digit.ContainsKey(StringHashCode20(str));
            Console.WriteLine(digit.ContainsKey(StringHashCode20(str)));
            Console.WriteLine(StringHashCode20(str));

            digit.Add(Simple_hash(str), str);
            digit.ContainsKey(Simple_hash(str));
            Console.WriteLine(digit.ContainsKey(Simple_hash(str)));
            Console.WriteLine(Simple_hash(str));

            Console.ReadKey();
        }

        //хеш функция дающаяя 100% гарантию индивидуальности ключей
        public static int StringHashCode20(string value)
        {
            int num = 352654597;
            int num2 = num;

            for (int i = 0; i < value.Length; i += 4)
            {
                int ptr0 = value[i] << 16;
                if (i + 1 < value.Length)
                    ptr0 |= value[i + 1];

                num = (num << 5) + num + (num >> 27) ^ ptr0;

                if (i + 2 < value.Length)
                {
                    int ptr1 = value[i + 2] << 16;
                    if (i + 3 < value.Length)
                        ptr1 |= value[i + 3];
                    num2 = (num2 << 5) + num2 + (num2 >> 27) ^ ptr1;
                }
            }

            return num + num2 * 1566083941;
        }

        //хеш функция со сложение и умноженгия
        public static int Simple_hash(string value)
        {
            int hash = 0;
            for (int i = 0; i < value.Length; i++)
            {
                hash = hash + value[i] * i;
            }

            return hash;
        }

    }
}
